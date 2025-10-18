using System;
using System.Globalization;
using System.Collections.Generic;
using OrderManagement.Entities;
using OrderManagement.Entities.Enums;

namespace OrderManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;

            Client Client = new Client(name, email, birthDate);

            Order Order = new Order(moment, status, Client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data: ");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                decimal priceProduct = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Products Item = new Products(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, Item);
                Order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(Order);

        }
    }
}