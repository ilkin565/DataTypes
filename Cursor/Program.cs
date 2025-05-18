using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cursor
{
	internal class Program
	{
		static int cursorX;
		static int cursorY;
		static char cursorSymbol = '+';

		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			cursorX = Console.WindowWidth / 2;
			cursorY = Console.WindowHeight / 2;

			while (true)
			{
				if (Console.KeyAvailable)
				{
					var key = Console.ReadKey(true).Key;

					Console.SetCursorPosition(cursorX, cursorY);
					Console.Write(' ');

					switch (key)
					{
						case ConsoleKey.W:
						case ConsoleKey.UpArrow:
							if (cursorY > 0) cursorY--;
							break;
						case ConsoleKey.S:
						case ConsoleKey.DownArrow:
							if (cursorY < Console.WindowHeight - 1) cursorY++;
							break;
						case ConsoleKey.A:
						case ConsoleKey.LeftArrow:
							if (cursorX > 0) cursorX--;
							break;
						case ConsoleKey.D:
						case ConsoleKey.RightArrow:
							if (cursorX < Console.WindowWidth - 1) cursorX++;
							break;
						case ConsoleKey.Escape:
							return;
					}
					Console.SetCursorPosition(cursorX, cursorY);
					Console.Write(cursorSymbol);
				}
			}
		}
	}
}