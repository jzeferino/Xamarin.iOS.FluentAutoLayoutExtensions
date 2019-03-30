[![Build Status](https://app.bitrise.io/app/0c6f922550bf11b2/status.svg?token=z_LkoxViFdElhUds1kYhtw&branch=master)](https://app.bitrise.io/app/0c6f922550bf11b2)
[![NuGet](https://img.shields.io/nuget/v/Xamarin.iOS.FluentAutoLayoutExtensions.svg?label=NuGet)](https://www.nuget.org/packages/Xamarin.iOS.FluentAutoLayoutExtensions/)

# Xamarin.iOS.FluentAutoLayoutExtensions

<p align="center">
  <img src="https://github.com/jzeferino/Xamarin.iOS.FluentAutoLayoutExtensions/blob/master/art/logo.png?raw=true"/>
</p>

Xamarin.iOS.FluentAutoLayoutExtensions is a set of extension methods that will help you write Auto Layout constraints with a lot of ease and speed.

The main goal of this project is to have basic building blocks that will help write less Auto Layout constraint code in a fluent way. 


# Usage examples

- Centering a view in the screen.

```
    var centeredView = new UIView { BackgroundColor = UIColor.Blue }.EnableAutoLayout();

    View.AddSubview(centeredView);

    centeredView.WithSize(200, 200);
    centeredView.WithSameCenterX(View);
    centeredView.WithSameCenterY(View);
```

<p align="center">
  <img src="https://github.com/jzeferino/Xamarin.iOS.FluentAutoLayoutExtensions/blob/master/art/centered.png?raw=true" width="300"/>
</p>

- Align view in bottom with relative size.

```
    var relativeSizeView = new UIView { BackgroundColor = UIColor.Orange }.EnableAutoLayout();
    View.AddSubview(relativeSizeView);

    relativeSizeView.WithRelativeWidth(View, 0.5f);
    relativeSizeView.WithRelativeHeight(View, 0.5f);
    relativeSizeView.WithSameBottom(View);
```

<p align="center">
  <img src="https://github.com/jzeferino/Xamarin.iOS.FluentAutoLayoutExtensions/blob/master/art/relative_size.png?raw=true" width="300"/>
</p>

- Align view to right of another view.

```
    var relativeSizeView = new UIView { BackgroundColor = UIColor.Orange }.EnableAutoLayout();
    var relativePositionView = new UIView { BackgroundColor = UIColor.Purple.ColorWithAlpha(0.3f) }.EnableAutoLayout();

    View.AddSubview(relativeSizeView);
    View.AddSubview(relativePositionView);

    relativeSizeView.WithRelativeWidth(View, 0.5f);
    relativeSizeView.WithRelativeHeight(View, 0.5f);
    relativeSizeView.WithSameBottom(View);
    relativeSizeView.WithSameLeading(View);

    relativePositionView.ToRightOf(relativeSizeView);
    relativePositionView.WithSameBottom(relativeSizeView);
    relativePositionView.WithSize(100, 200);
```

<p align="center">
  <img src="https://github.com/jzeferino/Xamarin.iOS.FluentAutoLayoutExtensions/blob/master/art/align_right.png?raw=true" width="300"/>
</p>

# Documentation

- You can take a look at the full documentation [here](docs/Xamarin.iOS.FluentAutoLayoutExtensions/FluentAutoLayoutExtensions.md).

