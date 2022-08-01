using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new Acc();

            acc.PayWithCard();

            acc.Pay();

            int number = 10;

            Console.WriteLine(number.IsBigger((10)));

            Console.WriteLine(number.MultiplyFor100());

            Console.ReadKey();
        }
    }
}


