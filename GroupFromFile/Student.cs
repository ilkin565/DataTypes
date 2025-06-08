using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupFromFile
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public Student(string firstName, string lastName, int age, string group)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Group = group;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Возраст: {Age}, Группа: {Group}";
        }
    }
}
