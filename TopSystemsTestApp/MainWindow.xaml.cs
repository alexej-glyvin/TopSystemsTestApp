using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using TopSystemsTestApp.Figures;

namespace TopSystemsTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IList<Figure> _figures = new List<Figure>();

        public MainWindow()
        {
            InitializeComponent();
            InitFigures();
            Draw();
            Move(new Vector(170, 20));
        }

        private void InitFigures()
        {
            _figures.Add(new Circle(new Point(10, 10), new Point(20, 20)) {Stroke = Brushes.Red });
            _figures.Add(new Line(new Point(120, 120), new Point(200, 200)) { Stroke = Brushes.Green });
            _figures.Add(new Rectangle(new Point(40, 40), 10, 30) { Stroke = Brushes.Blue });
            _figures.Add(new Triangle(new Point(10, 10), new Point(100, 70), new Point(60, 60)) { Stroke = Brushes.Orange });
            foreach (var figure in _figures)
            {
                figure.SetUiElement(grid1.Children);
            }
        }

        public void Draw()
        {
            foreach (var figure in _figures)
            {
                if (!figure.CanDraw()) 
                    continue;
                figure.Draw();
            }
        }

        public void Move(Vector shift)
        {
            foreach (var figure in _figures)
            {
                if (!figure.CanDraw())
                    continue;
                figure.Move(shift);
                figure.Redraw();
            }
        }
    }
}