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
            var centeredView = new UIView { BackgroundColor = UIColor.Blue }.EnableAutoLayout();
            var relativeSizeView = new UIView { BackgroundColor = UIColor.Orange }.EnableAutoLayout();
            var rightTopSafeMarginView = new UIView { BackgroundColor = UIColor.Green }.EnableAutoLayout();
            var fullSizeView = new UIView { BackgroundColor = UIColor.Purple.ColorWithAlpha(0.3f) }.EnableAutoLayout();
            var relativePositionView = new UIView { BackgroundColor = UIColor.Purple.ColorWithAlpha(0.3f) }.EnableAutoLayout();

            View.AddSubview(centeredView);
            View.AddSubview(fullSizeView);
            View.AddSubview(leftTopView);
            View.AddSubview(relativeSizeView);
            View.AddSubview(rightTopSafeMarginView);
            View.AddSubview(relativePositionView);

            fullSizeView.FullSizeOf(View);

            centeredView.WithSize(200, 200);
            centeredView.WithSameCenterX(View);
            centeredView.WithSameCenterY(View);

            leftTopView.WithSize(48, 48);
            leftTopView.WithSameTop(View);
            leftTopView.WithSameLeading(View);

            rightTopSafeMarginView.WithSize(100, 100);
            rightTopSafeMarginView.WithSameSafeTopSafeArea(View);
            rightTopSafeMarginView.WithSameTrailing(View);

            relativeSizeView.WithRelativeWidth(View, 0.5f);
            relativeSizeView.WithRelativeHeight(View, 0.5f);
            relativeSizeView.WithSameBottom(View);
            relativeSizeView.WithSameLeading(View);

            relativePositionView.ToRightOf(relativeSizeView);
            relativePositionView.WithSameBottom(relativeSizeView);
            relativePositionView.WithSize(100, 200);
        }
    }
}