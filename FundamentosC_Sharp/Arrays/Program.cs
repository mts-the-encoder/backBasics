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
            var funcs = new Func[1];
            funcs[0] = new Func() { Id = 13, Name = "matheus" };

            foreach (var func in funcs)
            {
                Console.WriteLine(func.Id);
                Console.WriteLine(func.Name);
            }
            
        }
    }
}

public struct Func
{
    public int Id { get; set; }

    public string Name { get; set; }
}
