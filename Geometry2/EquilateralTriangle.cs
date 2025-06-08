using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry2
{
    class EquilateralTriangle : Shape
    {
        public double Side { get; set; }

        // Высота равностороннего треугольника
        private double Height => Math.Sqrt(3) / 2 * Side;

        public EquilateralTriangle(double side, int start_x, int start_y,
                                   int line_width, Color color)
           : base(start_x, start_y - (int)(Math.Sqrt(3) / 6 * side), line_width, color) // смещение для правильного расположения
        {
            Side = side;
        }

        public override double GetArea() => Math.Sqrt(3) / 4 * Side * Side;

        public override double GetPerimeter() => 3 * Side;

        // Высота треугольника
        public override double GetHeight() => Height;

        // Рисование треугольника
        public override void Draw(PaintEventArgs e)
        {
            Point[] points =
            {
           new Point(StartX + (int)(Side/2), StartY),
           new Point(StartX + (int)Side , StartY),
           new Point(StartX , StartY)
       };
            using (Pen pen = new Pen(Color, LineWidth))
            {
                e.Graphics.DrawPolygon(pen, points);
            }
        }

        // Вывод свойств
        public void PrintProperties()
        {
            Console.WriteLine($"Равносторонний треугольник: сторона = {Side:F2}");
        }
    }
}
