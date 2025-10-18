using System;
using TaxSystem.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace TaxSystem
{
    internal class TaxSystem
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int quantityPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityPayers; i++)
            {
                Console.Write($"\nEnter Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c): ");
                char option = char.Parse(Console.ReadLine());

                if (option == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualincome, healthexpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberofemployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualincome, numberofemployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + " $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            double totalTaxes = 0;
            foreach (TaxPayer payer in list)
            {
                totalTaxes += payer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}