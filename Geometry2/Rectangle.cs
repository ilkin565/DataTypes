using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry2
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;

        public override double GetPerimeter() => 2 * (Width + Height);

        public override void Draw(PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color, LineWidth))
            {
                e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
            }
        }

        public void PrintProperties()
        {
            Console.WriteLine($"Прямоугольник: ширина = {Width:F2}, высота = {Height:F2}");
        }
    }
}
