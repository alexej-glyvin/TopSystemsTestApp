using System.Windows;
using System.Windows.Media;

namespace TopSystemsTestApp.Figures;

internal class Line: Figure
{
    protected Point Pt;

    public Line(Point start, Point end): base(start)
    {
        this.Pt = end;
    }
    public override void InitDraw()
    {
        Geometry.AddGeometry(new LineGeometry(Position, Pt));
    }

    public override void Move(Vector shift)
    {
        base.Move(shift);
        Pt = Point.Add(Position, shift);
    }
}