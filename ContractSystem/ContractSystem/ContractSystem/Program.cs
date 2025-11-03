using System;
using System.Globalization;
using System.Collections.Generic;
using ContractSystem.Entities;
using ContractSystem.Services;
using ContractSystem.Entities.Exceptions;

namespace MyApp
{
    internal class ContractSystem
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("ENTER CONTRACT DATA: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract Value: ");
                double totalvalue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int months = int.Parse(Console.ReadLine());

                Contract myContract = new Contract(number, date, totalvalue);
                ContractService contractService = new ContractService(new PaypalService());
                contractService.processContract(myContract, months);

                Console.WriteLine("\nInstallments: ");
                foreach (Installment installments in myContract.Installments)
                {
                    Console.WriteLine(installments);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error Processing " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}