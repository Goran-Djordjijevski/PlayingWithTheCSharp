using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WPFSimpleApp
{
    public class Circle : Shape
    {
        public Circle(Canvas canvas) : base(canvas)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 10;
            ellipse.Height = 10;
            ellipse.Fill = new SolidColorBrush(Colors.Green);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            Element = ellipse;
        }
    }
}
