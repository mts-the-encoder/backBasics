using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;

            //var format = String.Format("{0:yyyy-MM-dd hh:mm:ss}", data);
            //var formatt = String.Format("{0:t}", data);
            //var formatt = String.Format("{0:D}", data);
            //var formatt = String.Format("{0:f}", data);
            var formatt = String.Format("{0:r}", data);
            var format = $"{data}";
            Console.WriteLine(formatt);
        }
    }
}