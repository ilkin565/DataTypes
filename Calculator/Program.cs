using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите 'выход' для выхода");

			while (true)
			{
				Console.Write("Введите выражение: ");
				string input = Console.ReadLine();

				if (input.Trim().ToLower() == "выход")
				{
					break;
				}

				try
				{
					var result = EvaluateExpression(input);
					Console.WriteLine($"Результат: {result}");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Ошибка: {ex.Message}");
				}
			}
		}

		static double EvaluateExpression(string expression)
		{
			var dataTable = new DataTable();
			return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
		}
	}
}