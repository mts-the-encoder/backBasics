using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal value = 10.25m;
            Console.WriteLine(value.ToString(
                //P, porcentagem. F
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")));

        }
    }
}