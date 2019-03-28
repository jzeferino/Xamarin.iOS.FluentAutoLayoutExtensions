namespace Xamarin.iOS.FluentAutoLayoutExtensions
{
    public static partial class FluentAutoLayoutExtensions
    {
        /// <summary>
        /// Margins.
        /// </summary>
        public class Margins
        {
            /// <summary>
            /// Gets or sets the top margin.
            /// </summary>
            /// <value>The top.</value>
            public float Top { get; set; }

            /// <summary>
            /// Gets or sets the bottom margin.
            /// </summary>
            /// <value>The bottom.</value>
            public float Bottom { get; set; }

            /// <summary>
            /// Gets or sets the left margin.
            /// </summary>
            /// <value>The left.</value>
            public float Left { get; set; }

            /// <summary>
            /// Gets or sets the right margin.
            /// </summary>
            /// <value>The right.</value>
            public float Right { get; set; }

            /// <summary>
            /// Initializes a new instance of the
            /// <see cref="T:Xamarin.iOS.FluentAutoLayoutExtensions.FluentAutoLayoutExtensions.Margins"/> class.
            /// </summary>
            public Margins()
            {
            }

            /// <summary>
            /// Initializes a new instance of the
            /// <see cref="T:Xamarin.iOS.FluentAutoLayoutExtensions.FluentAutoLayoutExtensions.Margins"/> class.
            /// </summary>
            /// <param name="all">All.</param>
            public Margins(float all)
            {
                Top = all;
                Bottom = all;
                Right = all;
                Left = all;
            }

            /// <summary>
            /// Initializes a new instance of the
            /// <see cref="T:Xamarin.iOS.FluentAutoLayoutExtensions.FluentAutoLayoutExtensions.Margins"/> class.
            /// </summary>
            /// <param name="top">Top margin.</param>
            /// <param name="left">Left margin.</param>
            /// <param name="bottom">Bottom margin.</param>
            /// <param name="right">Right margin.</param>
            public Margins(float top, float left, float bottom, float right)
            {
                Top = top;
                Bottom = bottom;
                Right = right;
                Left = left;
            }
        }
    }
}
