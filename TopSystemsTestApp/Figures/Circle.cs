using System.Windows;
using System.Windows.Media;

namespace TopSystemsTestApp.Figures
{
    internal class Circle : Figure
    {
        protected double Radius;
        public Circle(Point center, double radius): base(center)
        {
            this.Radius = radius;
        }
        public Circle(Point center, Point pt)
            : this(center, Point.Subtract(center, pt).Length)
        {
        }

        public override void InitDraw()
        {
            Geometry.AddGeometry(new EllipseGeometry(Position, Radius, Radius));
        }
    }
}
