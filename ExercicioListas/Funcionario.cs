using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioListas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double perc)
        {
            Salary += ((perc / 100.0) * Salary);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", $ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
