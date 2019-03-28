
#tool "GitVersion.CommandLine&version=4.0.0"
#addin nuget:?package=Cake.XmlDocMarkdown&version=1.4.2

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var buildVerbosity = Argument("buildVerbosity", Verbosity.Minimal);

// Define directories.
var solutionFile = GetFiles("./src/*.sln").First();

// iOS.
var iOSProject = GetFiles("./src/Xamarin.iOS.FluentAutoLayoutExtensions/*.csproj").First();
var iOSSample = GetFiles("./src/Xamarin.iOS.FluentAutoLayoutExtensions.Sample/*.csproj").First();

// Output folder.
var artifactsDirectory = Directory("./artifacts");
var iOSOutputDirectory = "bin/";

GitVersion currentVersion = null;

Setup(ctx =>
{
	currentVersion = GitVersion(new GitVersionSettings
	{
		UpdateAssemblyInfo = false,
	});

	Information("Current gitversion is {0}", currentVersion.NuGetVersion);	
 	Information("IsRunningOnBitRise {0}", BuildSystem.IsRunningOnBitrise);	
 
	if (BuildSystem.IsRunningOnBitrise)
 	{
		BuildSystem.Bitrise.SetEnvironmentString("BITRISE_BUILD_NUMBER", currentVersion.NuGetVersion);
 	}
});

Task("Clean-Solution")
	.IsDependentOn("Clean-ArtifactsFolder")
	.Does(() => 
	{
		CleanDirectories ("./**/bin");
		CleanDirectories ("./**/obj");

		MSBuild(solutionFile, settings => settings
			.SetConfiguration(configuration)
			.WithTarget("Clean")
			.SetVerbosity(buildVerbosity));
	});

Task("Clean-ArtifactsFolder")
	.Does(() => 
	{
		CleanDirectory(artifactsDirectory);
	});

Task("Restore-Packages")
	.Does(() => 
	{
		NuGetRestore(solutionFile);
	});

Task("Prepare-Build")
	.IsDependentOn("Clean-Solution")
    .IsDependentOn("Restore-Packages")
    .Does (() => {});

Task("Build")
	.IsDependentOn("Build-Sample")
	.IsDependentOn("Build-Library")
	.Does(() => {});

Task("Build-Sample")
	.IsDependentOn("Prepare-Build")
	.Does(() =>  
	{	
		MSBuild(iOSSample, settings =>
			settings.SetConfiguration(configuration)
			.WithTarget("Build")
			.WithProperty("Platform", "iPhoneSimulator")
			.WithProperty("TreatWarningsAsErrors", "false")
			.WithProperty("OutputPath", iOSOutputDirectory)
			.SetVerbosity(buildVerbosity));
	});

Task("Build-Library")
	.IsDependentOn("Prepare-Build")
	.Does(() =>  
	{	
		MSBuild(iOSProject, settings => settings
					.SetConfiguration(configuration)
					.WithTarget("Build")
					.SetVerbosity(buildVerbosity));
	});	

Task ("NuGet")
	.IsDependentOn("Build")
	.IsDependentOn("Generate-Docs")
	.Does (() =>
	{	
		NuGetPack(
			"./nuspec/Xamarin.iOS.FluentAutoLayoutExtensions.nuspec", 
			new NuGetPackSettings 
			{ 
				Version = currentVersion.NuGetVersion,
				Verbosity = NuGetVerbosity.Normal,
				OutputDirectory = artifactsDirectory,
				BasePath = "./src",
			});	
	});

Task ("Publish-NuGetPackage")
	.IsDependentOn ("NuGet")
	.WithCriteria(() => BuildSystem.IsRunningOnBitrise)
	.Does (() => 
	{		
		var package = GetFiles(System.IO.Path.Combine(artifactsDirectory, "*.nupkg")).First();

		NuGetPush(
			package,
			new NuGetPushSettings {
				Source = Environment.GetEnvironmentVariable("NUGET_PACKAGE_SOURCE"),
				ApiKey = Environment.GetEnvironmentVariable("NUGET_PACKAGE_APY_KEY")
			});
	});

Task ("Generate-Docs")
	.IsDependentOn("Build")
	.Does (() => 
	{		
		XmlDocMarkdownGenerate($"./src/Xamarin.iOS.FluentAutoLayoutExtensions/bin/{configuration}/Xamarin.iOS.FluentAutoLayoutExtensions.dll", "./docs");
	});

Task("Default")
	.IsDependentOn("NuGet")
	.Does(() => {});

RunTarget(target);

