using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "test";
            Console.WriteLine(text.CompareTo("test"));
            Console.WriteLine(text.CompareTo("tesT"));
            Console.WriteLine(text.Contains("tesT"));
            Console.WriteLine(text.Contains("tEsT", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.Equals("test"));
            Console.WriteLine(text.Contains("detrás de ti imbécil"));
        }
    }
}