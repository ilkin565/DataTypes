using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{

			var dataTypesInfo = new (string TypeName, Type WrapperType, int MemorySize, string ValueRange)[]
			{
				("Bool", typeof(bool), sizeof(bool), $"{bool.FalseString}...{bool.TrueString}"),
				("Byte", typeof(byte), sizeof(byte), $"{byte.MinValue}...{byte.MaxValue}"),
				("SByte", typeof(sbyte), sizeof(sbyte), $"{sbyte.MinValue}...{sbyte.MaxValue}"),
				("Int16", typeof(short), sizeof(short), $"{short.MinValue}...{short.MaxValue}"),
				("UInt16", typeof(ushort), sizeof(ushort), $"{ushort.MinValue}...{ushort.MaxValue}"),
				("Int32", typeof(int), sizeof(int), $"{int.MinValue}...{int.MaxValue}"),
				("UInt32", typeof(uint), sizeof(uint), $"{uint.MinValue}...{uint.MaxValue}"),
				("Int64", typeof(long), sizeof(long), $"{long.MinValue}...{long.MaxValue}"),
				("UInt64", typeof(ulong), sizeof(ulong), $"{ulong.MinValue}...{ulong.MaxValue}"),
				("Float", typeof(float), sizeof(float), $"{float.MinValue}...{float.MaxValue}"),
				("Double", typeof(double), sizeof(double), $"{double.MinValue}...{double.MaxValue}"),
				("Decimal", typeof(decimal), sizeof(decimal), $"{decimal.MinValue}...{decimal.MaxValue}"),
				("Char", typeof(char), sizeof(char), $"'{char.MinValue}'...'{char.MaxValue}'")
			};

			foreach (var (TypeName, WrapperType, MemorySize, ValueRange) in dataTypesInfo)
			{
				Console.WriteLine($"Тип данных: {TypeName}");
				Console.WriteLine($"Класс-обертка: {WrapperType.Name}");
				Console.WriteLine($"Размер в памяти: {MemorySize} байт");
				Console.WriteLine($"Диапазон значений: {ValueRange}");
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}