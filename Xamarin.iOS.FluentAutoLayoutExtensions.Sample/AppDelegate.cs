using Foundation;
using UIKit;

namespace Xamarin.iOS.FluentAutoLayoutExtensions.Sample
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            (Window = new UIWindow(UIScreen.MainScreen.Bounds)).MakeKeyAndVisible();
            Window.RootViewController = new SampleViewController();
            return true;
        }
    }
}

