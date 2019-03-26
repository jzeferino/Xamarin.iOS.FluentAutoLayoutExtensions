using System;
using System.Collections.Generic;
using UIKit;

namespace Xamarin.iOS.FluentAutoLayoutExtensions
{
    public static partial class FluentAutoLayoutExtensions
    {
        private const float DefaultMargin = 0;
        private const float DefaultMultiplier = 1;

        /// <summary>
        /// Constraint with the same Top as <paramref name="anchorView"/> taking in account LayoutMarginsGuide.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameSafeTopSafeArea(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.TopAnchor.ConstraintEqualTo(anchorView.LayoutMarginsGuide.TopAnchor).Plus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint with the same Bottom as <paramref name="anchorView"/> taking in account LayoutMarginsGuide.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameBottomSafeArea(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.BottomAnchor.ConstraintEqualTo(anchorView.LayoutMarginsGuide.BottomAnchor).Minus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint with the same Top as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameTop(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.TopAnchor.ConstraintEqualTo(anchorView.TopAnchor).Plus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint with the same Bottom as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameBottom(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.BottomAnchor.ConstraintEqualTo(anchorView.BottomAnchor).Minus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint with the same Leading as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameLeading(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.LeadingAnchor.ConstraintEqualTo(anchorView.LeadingAnchor).Plus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint with the same Trailing as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameTrailing(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.TrailingAnchor.ConstraintEqualTo(anchorView.TrailingAnchor).Minus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint Below <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Previous.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint Below(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.TopAnchor.ConstraintEqualTo(anchorView.BottomAnchor).Plus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint Above <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint Above(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.BottomAnchor.ConstraintEqualTo(anchorView.TopAnchor).Minus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint to Right Of <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint ToRightOf(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.LeadingAnchor.ConstraintEqualTo(anchorView.TrailingAnchor).Plus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Constraint to Left Of <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint ToLeftOf(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.TrailingAnchor.ConstraintEqualTo(anchorView.LeadingAnchor).Minus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Center in X of <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameCenterX(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.CenterXAnchor.ConstraintEqualTo(anchorView.CenterXAnchor).Plus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Center in Y of <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithSameCenterY(this UIView view, UIView anchorView, nfloat? margin = null, float? priority = null) =>
        view.CenterYAnchor.ConstraintEqualTo(anchorView.CenterYAnchor).Plus(margin.GetValueOrDefault(DefaultMargin)).Priority(priority).Active();

        /// <summary>
        /// Set With with specified value.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="width">Width.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithWidth(this UIView view, nfloat width, float? priority = null) =>
        view.WidthAnchor.ConstraintEqualTo(width).Priority(priority).Active();

        /// <summary>
        /// Set Height with specified value.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="height">Height.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithHeight(this UIView view, nfloat height, float? priority = null) =>
        view.HeightAnchor.ConstraintEqualTo(height).Priority(priority).Active();

        /// <summary>
        /// Constraint to the same With as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraints.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        public static IEnumerable<NSLayoutConstraint> WithSameWidth(this UIView view, UIView anchorView, nfloat? margin = null)
        {
            var marginValue = margin.GetValueOrDefault(DefaultMargin);

            return new List<NSLayoutConstraint>
            {
                view.WithSameLeading(anchorView, marginValue),
                view.WithSameTrailing(anchorView, marginValue)
            };
        }

        /// <summary>
        /// Constraint to the same Height as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraints.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        public static IEnumerable<NSLayoutConstraint> WithSameHeight(this UIView view, UIView anchorView, nfloat? margin = null)
        {
            var marginValue = margin.GetValueOrDefault(DefaultMargin);

            return new List<NSLayoutConstraint>
            {
                view.WithSameTop(anchorView, marginValue),
                view.WithSameBottom(anchorView, marginValue)
            };
        }

        /// <summary>
        /// Constraint to a Width relative to <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="multiplier">Multiplier.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithRelativeWidth(this UIView view, UIView anchorView, nfloat? multiplier = null, float? priority = null) =>
        view.WidthAnchor.ConstraintEqualTo(anchorView.WidthAnchor, multiplier.GetValueOrDefault(DefaultMultiplier)).Priority(priority).Active();

        /// <summary>
        /// Constraint to a Height relative to <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="multiplier">Multiplier.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint WithRelativeHeight(this UIView view, UIView anchorView, nfloat? multiplier = null, float? priority = null) =>
        view.HeightAnchor.ConstraintEqualTo(anchorView.HeightAnchor, multiplier.GetValueOrDefault(DefaultMultiplier)).Priority(priority).Active();

        /// <summary>
        /// Constraint to the same size as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraints.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margin">Margin.</param>
        public static IEnumerable<NSLayoutConstraint> FullSizeOf(this UIView view, UIView anchorView, nfloat margin) =>
        FullSizeOf(view, anchorView, new Margins((float)margin));

        /// <summary>
        /// Constraint to the same size as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraints.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="top">Top.</param>
        /// <param name="left">Left.</param>
        /// <param name="bottom">Bottom.</param>
        /// <param name="right">Right.</param>
        public static IEnumerable<NSLayoutConstraint> FullSizeOf(this UIView view, UIView anchorView, nfloat? top = null, nfloat? left = null, nfloat? bottom = null, nfloat? right = null) =>
            FullSizeOf(view, anchorView, new Margins((float)top.GetValueOrDefault(DefaultMargin), (float)left.GetValueOrDefault(DefaultMargin), (float)bottom.GetValueOrDefault(DefaultMargin), (float)right.GetValueOrDefault(DefaultMargin)));

        /// <summary>
        /// Constraint to the same size as <paramref name="anchorView"/>.
        /// </summary>
        /// <returns>The constraints.</returns>
        /// <param name="view">View.</param>
        /// <param name="anchorView">Anchor view.</param>
        /// <param name="margins">Margins.</param>
        private static IEnumerable<NSLayoutConstraint> FullSizeOf(this UIView view, UIView anchorView, Margins margins)
        {
            margins = margins ?? new Margins();

            return new List<NSLayoutConstraint>
            {
                view.WithSameTop(anchorView, margins.Top),
                view.WithSameBottom(anchorView, margins.Bottom),
                view.WithSameLeading(anchorView, margins.Left),
                view.WithSameTrailing(anchorView, margins.Right)
            };
        }

        /// <summary>
        /// Constraint with the specified Width and Height.
        /// </summary>
        /// <returns>The constraints.</returns>
        /// <param name="view">View.</param>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        public static NSLayoutConstraint[] WithSize(this UIView view, float width, float height)
        {
            return new[]
            {
                view.WithWidth(width),
                view.WithHeight(height)
            };
        }

        /// <summary>
        /// Enables auto layout.
        /// </summary>
        /// <returns>The view.</returns>
        /// <param name="origin">Origin.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static T EnableAutoLayout<T>(this T origin) where T : UIView
        {
            origin.TranslatesAutoresizingMaskIntoConstraints = false;
            return origin;
        }

        /// <summary>
        /// Add the specified <paramref name="constant"/> to a constraint.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="constraint">Constraint.</param>
        /// <param name="constant">Constant.</param>
        public static NSLayoutConstraint Plus(this NSLayoutConstraint constraint, nfloat constant)
        {
            constraint.Constant += constant;
            return constraint;
        }

        /// <summary>
        /// Removes the specified <paramref name="constant"/> to a constraint.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="constraint">Constraint.</param>
        /// <param name="constant">Constant.</param>
        public static NSLayoutConstraint Minus(this NSLayoutConstraint constraint, nfloat constant)
        {
            constraint.Constant -= constant;
            return constraint;
        }

        /// <summary>
        /// Set the specified <paramref name="priority"/> to a constraint.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="constraint">Constraint.</param>
        /// <param name="priority">Priority.</param>
        public static NSLayoutConstraint Priority(this NSLayoutConstraint constraint, float? priority = null)
        {
            if (priority.HasValue)
            {
                constraint.Priority = priority.Value;
            }
            return constraint;
        }

        /// <summary>
        /// Active a constraint.
        /// </summary>
        /// <returns>The constraint.</returns>
        /// <param name="constraint">Constraint.</param>
        /// <param name="active">If set to <c>true</c> active.</param>
        public static NSLayoutConstraint Active(this NSLayoutConstraint constraint, bool active = true)
        {
            constraint.Active = active;
            return constraint;
        }

        /// <summary>
        /// Sets the content hugging priority.
        /// </summary>
        /// <param name="view">View.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="axis">Axis.</param>
        public static void SetContentHuggingPriority(this UIView view, UILayoutPriority priority, UILayoutConstraintAxis axis)
        {
            view.SetContentHuggingPriority((float)priority, axis);
        }

        /// <summary>
        /// Sets the content compression resistance priority.
        /// </summary>
        /// <param name="view">View.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="axis">Axis.</param>
        public static void SetContentCompressionResistancePriority(this UIView view, UILayoutPriority priority, UILayoutConstraintAxis axis)
        {
            view.SetContentCompressionResistancePriority((float)priority, axis);
        }
    }
}
