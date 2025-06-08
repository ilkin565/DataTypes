using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Specialist : Student
    {
        public string Specialization { get; set; }
        public string CertificationLevel { get; set; }

        public Specialist(string last_name, string first_name, int age,
                          string speciality, string group,
                          double rating, double attendance,
                          string specialization, string certificationLevel)
            : base(last_name, first_name, age, speciality, group, rating, attendance)
        {
            Specialization = specialization;
            CertificationLevel = certificationLevel;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Specialization: {Specialization}, Certification Level: {CertificationLevel}");
        }

        public override string ToString()
        {
            return base.ToString() + $" | {Specialization} | {CertificationLevel}";
        }

        public override string ToFileString()
        {
            return base.ToFileString() + $",{Specialization},{CertificationLevel}";
        }

        public override Human Init(string[] values)
        {
            base.Init(values);
            if (values.Length >= 10)
            {
                this.Specialization = values[8];
                this.CertificationLevel = values[9];
            }
            return this;
        }
    }
}