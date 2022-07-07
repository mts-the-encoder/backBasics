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


                Register("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Indice não encontrado na lista");
            }
            catch (ArgumentNullException ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Falha ao cadastrar");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                //Console.WriteLine(e.Message);
                System.Console.WriteLine("algo deu errado");
                throw;
            }
        }

        private static void Register(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
            }
        }
    }
}