using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(2, "caderno", 10.50);

            product.Id = 40;

            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);    
            Console.WriteLine(product.Price);

        }
    }

    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDollar(double dolar)
        {
            return Price * dolar;
        }
    }
}