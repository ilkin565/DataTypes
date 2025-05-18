using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int size;
			while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
			{
				Console.Write("Пожалуйста, введите положительное целое число: ");
			}

			Console.WriteLine("\nКвадрат:");
			DrawSquare(size);

			Console.WriteLine("\nТреугольник:");
			DrawTriangle(size);

			Console.WriteLine("\nПеревернутый треугольник:");
			DrawInvertedTriangle(size);

			Console.WriteLine("\nПравый треугольник:");
			DrawRightTriangle(size);

			Console.WriteLine("\nРавнобедренный треугольник:");
			DrawIsoscelesTriangle(size);

			Console.WriteLine("\nРомб:");
			DrawDiamond(size);
		}

		static void DrawSquare(int size)
		{
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawTriangle(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawInvertedTriangle(int size)
		{
			for (int i = size; i >= 1; i--)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawRightTriangle(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}

		static void DrawIsoscelesTriangle(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				for (int j = size - i; j > 0; j--)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= (2 * i - 1); k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}

		static void DrawDiamond(int size)
		{
			for (int i = 1; i <= size; i++)
			{
				for (int j = size - i; j > 0; j--)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= (2 * i - 1); k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			for (int i = size - 1; i >= 1; i--)
			{
				for (int j = size - i; j > 0; j--)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= (2 * i - 1); k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}
	}
}