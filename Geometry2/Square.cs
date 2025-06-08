using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry2
{
    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Side = side;
        }

        public override double GetArea() => Side * Side;

        public override double GetPerimeter() => 4 * Side;

        public override void Draw(PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color, LineWidth))
            {
                e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Side, (float)Side);
            }
        }

        public void PrintProperties()
        {
            Console.WriteLine($"Квадрат: сторона = {Side:F2}");
        }
    }
}
