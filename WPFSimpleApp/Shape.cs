using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFSimpleApp
{
    public class Shape
    {
        public Shape(Canvas canvas)
        {
            this.Canvas = canvas;
        }

        public Canvas Canvas { get; set; }
        public UIElement Element { get; set; }
        static Random random = new Random();

        public void Draw()
        {
            double left = Canvas.ActualWidth * random.NextDouble();
            double top = Canvas.ActualHeight * random.NextDouble();
            Element.SetValue(Canvas.LeftProperty, left);
            Element.SetValue(Canvas.TopProperty, top);
            Canvas.Children.Add(Element);
        }
    }
}
