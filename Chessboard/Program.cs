using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер блока:");
			int size;

			while (!int.TryParse(Console.ReadLine(), out size) || size <= 0) ;

			int repeatCount = 4;

			for (int row = 0; row < repeatCount * size; row++)
			{
				for (int col = 0; col < repeatCount * size; col++)
				{
					bool isStarCell = ((row / size) + (col / size)) % 2 == 0;

					if (isStarCell)
						Console.Write("* ");
					else
						Console.Write("  ");
				}
				Console.WriteLine();
			}

			Console.ReadKey();
		}
	}
}