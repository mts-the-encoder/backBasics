using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //var data = DateTime.Now;
            var data = new DateTime(2022, 7, 7, 00, 10, 20);
            Console.WriteLine(data.ToString());
            Console.WriteLine(data.Year);

            Console.WriteLine(data.DayOfYear);
        }
    }
}