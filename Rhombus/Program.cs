using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер ромба:");
			int size;
			while (!int.TryParse(Console.ReadLine(), out size) || size <= 0) ;

			int totalLines = 2 * size;

			for (int i = 1; i <= totalLines; i++)
			{
				int leadingSpaces;
				string line;

				if (i <= size)
				{
					leadingSpaces = size - i;
					line = new string(' ', leadingSpaces) + " /" + new string(' ', 2 * i - 2) + "\\";
				}
				else
				{
					leadingSpaces = i - size;
					line = new string(' ', leadingSpaces) + "\\" + new string(' ', 2 * (totalLines - i) + 0) + "/";
				}

				Console.WriteLine(line);
			}

			Console.ReadKey();
		}
	}
}