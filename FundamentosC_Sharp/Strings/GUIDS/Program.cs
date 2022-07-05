using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            //id = new Guid("a2f8b7a5-503e-43e2-947e-700d2bf8502c");
            Console.WriteLine(id.ToString().Substring(0,8));
        }
    }
}

