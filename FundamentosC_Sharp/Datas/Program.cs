using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;

            // var format = String.Format("{0:yyyy-MM-dd hh:mm:ss}", data);
            var format = $"{data}";
            Console.WriteLine(format);
        }
    }
}