using UIKit;
using System;

namespace Xamarin.iOS.FluentAutoLayoutExtensions.Sample
{
    internal class SampleViewController : UIViewController, IUITableViewDelegate
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.White;

            var leftTopView = new UIView { BackgroundColor = UIColor.Red }.EnableAutoLayout();
            var centeredView = new UIView { BackgroundColor = UIColor.Black }.EnableAutoLayout();
            var relativeSizeView = new UIView { BackgroundColor = UIColor.Orange }.EnableAutoLayout();
            var rightTopSafeMargin = new UIView { BackgroundColor = UIColor.Green }.EnableAutoLayout();

            View.AddSubview(centeredView);
            View.AddSubview(leftTopView);
            View.AddSubview(relativeSizeView);
            View.AddSubview(rightTopSafeMargin);

            centeredView.WithSize(200, 200);
            centeredView.WithSameCenterX(View);
            centeredView.WithSameCenterY(View);

            leftTopView.WithSize(48, 48);
            leftTopView.WithSameTop(View);
            leftTopView.WithSameLeading(View);

            rightTopSafeMargin.WithSize(100, 100);
            rightTopSafeMargin.WithSameSafeTopSafeArea(View);
            rightTopSafeMargin.WithSameTrailing(View);

            relativeSizeView.WithRelativeWidth(View, 0.5f);
            relativeSizeView.WithRelativeHeight(View, 0.5f);
            relativeSizeView.WithSameBottom(View);
        }
    }
}