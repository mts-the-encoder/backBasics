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
            catch (IndexOutOfRangeException ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Indice não encontrado na lista");
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