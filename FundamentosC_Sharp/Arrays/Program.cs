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
            int[] myArray = new int[] { 15, 21, 32, 44, 50 };

            //for (int i = 0; i < myArray.Length; i++)
            //{
                //Console.WriteLine(myArray[i]);
            //}

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
