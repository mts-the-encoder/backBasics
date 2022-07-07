using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal value = 10543.25m;
            //Console.WriteLine(value.ToString(
                //P, porcentagem. F
                //"C",
                //CultureInfo.CreateSpecificCulture("pt-BR")));
                //Console.WriteLine(Math.Round(value)); Arredonda
                Console.WriteLine(Math.Ceiling(value)); //Arredonda p cima
                Console.WriteLine(Math.Floor(value)); //Arredonda p baixo
        }
    }
}