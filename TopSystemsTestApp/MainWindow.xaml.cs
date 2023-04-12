using System.Collections.Generic;
using System.Windows;
using TopSystemsTestApp.Figures;
using Point = System.Windows.Point;

namespace TopSystemsTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList<Figure> figures;

        public MainWindow()
        {
            InitializeComponent();
            InitFigures();
            Draw();
        }

        private void InitFigures()
        {
            figures = new List<Figure>
            {
                new Circle(new Point(10, 10), new Point(20, 20)),
                new Line(new Point(120, 120), new Point(200, 200)),
                new Rectangle(new Point(40, 40), 10, 30),
                new Triangle(new Point(10, 10), new Point(100, 70), new Point(60, 60))
            };
            foreach (var figure in figures)
            {
                figure.SetUiElement(grid1.Children);
            }
        }

        public void Draw()
        {
            foreach (var figure in figures)
            {
                if (!figure.CanDraw()) continue;
                figure.Draw();
            }
        }

        public void Move(Vector shift)
        {
            foreach (var figure in figures)
            {
                figure.Move(new Vector(150, 150));
                figure.Redraw();
            }
        }
    }
}