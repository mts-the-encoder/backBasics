using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "   test, this Is A tEst   ";
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
            //Console.WriteLine(text.IndexOf(","));
            //Console.WriteLine(text.IndexOf("h"));

            //LowerUpper
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.Insert(5, " HERE "));
            //Console.WriteLine(text.Remove(10, 3));
            //Console.WriteLine(text.Length);

            Console.WriteLine(text.Replace("this", "isto"));
            Console.WriteLine(text.Replace("e", "x"));
            Console.WriteLine(text.Replace("x", "zzzzzzzzzzz"));

            var division = text.Split(" ");
            Console.WriteLine(division[0]);
            Console.WriteLine(division[1]);
            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);
            Console.WriteLine(division[4]);

            var result = text.Substring(6, 5);
            Console.WriteLine(result);

            Console.WriteLine(text.Trim());
        }

    }
}