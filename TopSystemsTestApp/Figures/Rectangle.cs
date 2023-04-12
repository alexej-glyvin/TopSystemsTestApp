using System.Windows;
using System.Windows.Media;

namespace TopSystemsTestApp.Figures
{
    internal class Rectangle: Figure
    {
        private Point Pt;
        public Rectangle(Point leftPt, Point pt): base(leftPt)
        {
            this.Pt = pt;
        }

        public Rectangle(Point leftPt, double width, double height)
        : this(leftPt, new Point(leftPt.X + width, leftPt.Y + height))
        {
            
        }
        public override void InitDraw()
        {
            Geometry.AddGeometry(new RectangleGeometry(new Rect(Position, Pt)));
        }

        public override void Move(Vector shift)
        {
            base.Move(shift);
            Pt = Point.Add(Pt, shift);
        }
    }
}
