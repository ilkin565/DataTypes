using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry2
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;

        public override double GetPerimeter() => 2 * Math.PI * Radius;

        public override void Draw(PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color, LineWidth))
            {
                e.Graphics.DrawEllipse(pen,
                    StartX - (float)Radius,
                    StartY - (float)Radius,
                    (float)(2 * Radius),
                    (float)(2 * Radius));
            }
        }

        public void PrintProperties()
        {
            Console.WriteLine($"Круг: радиус = {Radius:F2}");
        }
    }
}
