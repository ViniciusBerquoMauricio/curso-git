using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> employeesList = new List<Funcionario>();
            
            Console.Write("How many employees will be registered? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Employee #{0}", i);
                Console.Write("Id: ");
                int auxId = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string auxName = Console.ReadLine();
                Console.Write("Salary: ");
                double auxSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeesList.Add(new Funcionario(auxId, auxName, auxSalary));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("List of employess:");
            foreach (Funcionario x in employeesList)
            {
                Console.WriteLine(x);
            }

            Console.Write("Enter the employee id that will have a salary increase: ");
            int idSalaryIncrease = int.Parse(Console.ReadLine());

            Funcionario f = employeesList.Find(x => x.Id == idSalaryIncrease);

            if (f == null)
            {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.IncreaseSalary(percentage);
                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employess:");
            foreach (Funcionario x in employeesList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
