using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry2
{
    class Program
    {
        static Random rand = new Random();

        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            int count = 10; // число фигур

            for (int i = 0; i < count; i++)
            {
                int shapeType = rand.Next(4); // 0-квадрат ,1-прямоугольник ,2-круг ,3-треугольник

                switch (shapeType)
                {
                    case 0:
                        shapes.Add(CreateRandomSquare());
                        break;
                    case 1:
                        shapes.Add(CreateRandomRectangle());
                        break;
                    case 2:
                        shapes.Add(CreateRandomCircle());
                        break;
                    case 3:
                        shapes.Add(CreateRandomTriangle());
                        break;
                }
            }

            foreach (var shape in shapes)
            {
                Console.WriteLine("-----");
                if (shape is Square sq)
                {
                    sq.PrintProperties();
                }
                else if (shape is Rectangle rect)
                {
                    rect.PrintProperties();
                }
                else if (shape is Circle circ)
                {
                    circ.PrintProperties();
                }
                else if (shape is EquilateralTriangle tri)
                {
                    tri.PrintProperties();
                }

                Console.WriteLine("Основные свойства:");
                Console.WriteLine($"Положение: ({shape.StartX}, {shape.StartY})");
                Console.WriteLine($"Цвет: {shape.Color}");

                Console.WriteLine("Вторичные свойства:");
                shape.Info();

                // Нарисовать фигуру можно в графическом контексте Windows Forms.
            }

            Console.ReadLine();
        }

        static Square CreateRandomSquare()
        {
            double side = rand.Next(MIN_SIZE + 10, MAX_SIZE);
            return new Square(side,
                              rand.Next(0, 300),
                              rand.Next(0, 300),
                              rand.Next(1, 5),
                              RandomColor());
        }

        static Rectangle CreateRandomRectangle()
        {
            double w = rand.Next(MIN_SIZE + 10, MAX_SIZE);
            double h = rand.Next(MIN_SIZE + 10, MAX_SIZE);
            return new Rectangle(w, h,
                                rand.Next(0, 300),
                                rand.Next(0, 300),
                                rand.Next(1, 5),
                                RandomColor());
        }


        static Circle CreateRandomCircle()
        {
            double r = rand.Next(MIN_SIZE + 10, MAX_SIZE);
            return new Circle(r,
                rand.Next(0, 300),
                rand.Next(0, 300),
                rand.Next(1, 5),
                RandomColor());
        }

        static EquilateralTriangle CreateRandomTriangle()
        {
            double s = rand.Next(MIN_SIZE + 10, MAX_SIZE);
            return new EquilateralTriangle(s,
                rand.Next(0, 300),
                rand.Next(0, 300),
                rand.Next(1, 5),
                RandomColor());
        }

        static Color RandomColor()
        {
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 200;


    }
}
