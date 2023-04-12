using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TopSystemsTestApp.Figures
{
    internal class Triangle: Figure
    {
        private Point Pt2;
        private Point Pt3;

        public Triangle(Point pt1, Point pt2, Point pt3): base(pt1) 
        {
            this.Pt2 = pt2;
            this.Pt3 = pt3;
        }

        public override void InitDraw()
        {
            var fig = new PathFigure
            {
                StartPoint = Position
            };
            PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
            myPathSegmentCollection.Add(new LineSegment(Pt2, true));
            myPathSegmentCollection.Add(new LineSegment(Pt3, true));
            myPathSegmentCollection.Add(new LineSegment(Position, true));
            fig.Segments = myPathSegmentCollection;

            Geometry.Figures.Add(fig);


        }

        public override void Move(Vector shift)
        {
            base.Move(shift);
            Pt2 = Point.Add(Pt2, shift); 
            Pt3 = Point.Add(Pt3, shift); 
        }
    }
}
