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
        public MainWindow()
        {
            InitializeComponent();
            TestFigures();
        }

        private void TestFigures()
        {
            var editor = new ImageEditor(grid1.Children);
            editor.Add(new Circle(new Point(10, 10), new Point(20, 20)) { Stroke = Brushes.Red });
            editor.Add(new Line(new Point(120, 120), new Point(200, 200)) { Stroke = Brushes.Green });
            editor.Add(new Rectangle(new Point(40, 40), 10, 30) { Stroke = Brushes.Blue });
            editor.Add(new Triangle(new Point(10, 10), new Point(100, 70), new Point(60, 60)) { Stroke = Brushes.Orange });

            editor.Draw();
            editor.Move(new Vector(170, 20));
        }
    }
}