using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "test, this is a test";
            //Console.WriteLine(text.CompareTo("test"));
            //Console.WriteLine(text.CompareTo("tesT"));
            //Console.WriteLine(text.Contains("tesT"));
            //Console.WriteLine(text.Contains("tEsT", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(text.Equals("test"));
            //Console.WriteLine(text.Contains("detrás de ti imbécil"));
            //Console.WriteLine("\r\n");

            //StarsWith & EndsWith

            //Console.WriteLine(text.StartsWith("test"));
            //Console.WriteLine(text.StartsWith(" test"));
            //Console.WriteLine(text.StartsWith("Test", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(text.StartsWith("Test"));

            //Console.WriteLine("\n");
            //Console.WriteLine(text.EndsWith("t"));
            //Console.WriteLine(text.EndsWith("St"));
            //Console.WriteLine(text.EndsWith("sT"));
            //Console.WriteLine(text.EndsWith("ST", StringComparison.OrdinalIgnoreCase));

            //Index
            Console.WriteLine(text.IndexOf(","));
            Console.WriteLine(text.IndexOf("h"));

        }

    }
}