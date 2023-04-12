using System.Windows;

namespace TopSystemsTestApp.Figures;

internal class Square: Rectangle
{
    public Square(Point start, double width)
        : base(start, width, width)
    {
    }

}