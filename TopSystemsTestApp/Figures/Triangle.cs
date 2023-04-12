using System.Windows;
using System.Windows.Media;

namespace TopSystemsTestApp.Figures
{
    internal class Triangle: Figure
    {
        private Point _pt2;
        private Point _pt3;

        public Triangle(Point pt1, Point pt2, Point pt3): base(pt1) 
        {
            this._pt2 = pt2;
            this._pt3 = pt3;
        }

        public override void InitDraw()
        {
            var fig = new PathFigure
            {
                StartPoint = Position
            };
            var myPathSegmentCollection = new PathSegmentCollection
            {
                new LineSegment(_pt2, true),
                new LineSegment(_pt3, true),
                new LineSegment(Position, true)
            };
            fig.Segments = myPathSegmentCollection;

            Geometry.Figures.Add(fig);
        }

        public override void Move(Vector shift)
        {
            base.Move(shift);
            _pt2 = Point.Add(_pt2, shift); 
            _pt3 = Point.Add(_pt3, shift); 
        }
    }
}
