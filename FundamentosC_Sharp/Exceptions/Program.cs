using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                //Console.WriteLine(e.Message);
                System.Console.WriteLine("algo deu errado");
                throw;
            }
        }
    }
}