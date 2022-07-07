using System;
using System.Globalization;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var myArray = new int[5];
            int[] myArray = new int[] { new Test() };

            Console.WriteLine(myArray[0].Id);
            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray[2]);
            Console.WriteLine(myArray[3]);
            Console.WriteLine(myArray[4]);
        }
    }
}

struct Test
{
    public int Id { get; set; }
}