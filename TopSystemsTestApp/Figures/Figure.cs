using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TopSystemsTestApp.Figures
{
    internal abstract class Figure
    {
        protected Point Position;
        protected UIElementCollection UiElement;
        protected Brush Stroke;
        protected PathGeometry Geometry;

        protected Figure()
        {
            Stroke = Brushes.Black;
            Geometry = new PathGeometry();
        }

        protected Figure(Point position)
            : this()
        {
            Position = position;
        }

        public void SetUiElement(UIElementCollection graphCollection)
        {
            this.UiElement = graphCollection;
        }

        public abstract void InitDraw();

        public bool CanDraw()
        {
            return  UiElement != null;
        }

        public virtual void Move(Vector shift)
        {
            Position = Point.Add(Position, shift);
        }

        public void Draw()
        {
            InitDraw();
            Path path = new()
            {
                Stroke = this.Stroke,
                Data = Geometry
            };
            UiElement.Add(path);
        }

        public void Redraw()
        {
            Geometry.Clear();
            Draw();
        }
    }
}
