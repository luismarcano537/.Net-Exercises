using System;
using System.IO;
using System.Linq;
using System.Globalization;
using ExerciseLambda02.Entities;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double LimitSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> Employees = new List<Employee>();

            try
            {
                using (StreamReader Sr = File.OpenText(path))
                {
                    while (!Sr.EndOfStream)
                    {
                        string[] fields = Sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        Employees.Add(new Employee(name, email, salary));
                    }
                }

                var emails = Employees.Where(E => E.Salary > LimitSalary).OrderBy(E => E.Name).Select(E => E.Email).ToList();

                var AllSallary = Employees.Where(E => E.Name[0] == 'M').Sum(E => E.Salary);

                Console.WriteLine("\nEmail of people whose salarry is more than 2000.00: ");
                foreach (var em in emails)
                {
                    Console.WriteLine(em);
                }

                Console.WriteLine("\nSum of salary of peoples whose name starts with 'm': " + AllSallary.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e) {

                Console.WriteLine("An error ocurred: " + e.Message);
            }

        }
    }
}