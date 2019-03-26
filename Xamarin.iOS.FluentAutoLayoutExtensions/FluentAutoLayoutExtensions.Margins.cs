namespace Xamarin.iOS.FluentAutoLayoutExtensions
{
    public static partial class FluentAutoLayoutExtensions
    {
        public class Margins
        {
            public float Top { get; set; }
            public float Bottom { get; set; }
            public float Left { get; set; }
            public float Right { get; set; }

            public Margins()
            {
            }

            public Margins(float all)
            {
                Top = all;
                Bottom = all;
                Right = all;
                Left = all;
            }

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
