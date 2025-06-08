using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ilkin\source\repos\Dz\GroupFromFile\group.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            List<Student> studentsList = new List<Student>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Разделяем строку по точке с запятой
                        string[] parts = line.Split(';');

                        if (parts.Length == 4)
                        {
                            string firstName = parts[0];
                            string lastName = parts[1];
                            if (int.TryParse(parts[2], out int age))
                            {
                                string group = parts[3];

                                Student student = new Student(firstName, lastName, age, group);
                                studentsList.Add(student);
                            }
                            else
                            {
                                Console.WriteLine($"Некорректный возраст в строке: {line}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Некорректный формат строки: {line}");
                        }
                    }
                }

                Student[] studentsArray = studentsList.ToArray();

                Console.WriteLine("Загруженные студенты:");
                foreach (var student in studentsArray)
                {
                    Console.WriteLine(student);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}