using System;
using ExerciseLambda.Models;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full Path file: ");
            string Path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader Sr = File.OpenText(Path))
            {
                while (!Sr.EndOfStream)
                {
                    string[] fields = Sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(P => P.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine("Average Price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(P => P.Price < avg).OrderByDescending(P => P.Name).DefaultIfEmpty().Select(P => P.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}