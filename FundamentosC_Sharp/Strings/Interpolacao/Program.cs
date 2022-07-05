using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            //var text = $"O preço é: {price}";
            var text = string.Format("O Preço é: {0}", price);
            Console.WriteLine(text);
        }
    }
}