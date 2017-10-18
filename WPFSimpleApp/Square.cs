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
    class Square : Shape
    {
        public Square(Canvas canvas) : base(canvas)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 10;
            rect.Fill = new SolidColorBrush(Colors.Green);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            Element = rect;
        }
    }
}
