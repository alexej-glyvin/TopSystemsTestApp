using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TopSystemsTestApp.Figures;

namespace TopSystemsTestApp
{
    internal class ImageEditor
    {
        private readonly IList<Figure> _figures = new List<Figure>();
        private readonly UIElementCollection _uiElement;

        public ImageEditor(UIElementCollection uiElement)
        {
            this._uiElement = uiElement;
        }
        public void Add(Figure figure)
        {
            _figures.Add(figure);
            figure.SetUiElement(_uiElement);
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
