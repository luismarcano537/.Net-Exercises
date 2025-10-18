using System;
using System.Globalization;

namespace OrderManagement.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Products Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, decimal price, Products product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }


        public decimal SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture)
                + " Quantity: " + Quantity
                + ", Subtotal: $ " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
