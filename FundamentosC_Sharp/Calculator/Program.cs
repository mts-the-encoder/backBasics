using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Division();
        }

        static void Sum()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float valueOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segubdo valor: ");
            float valueTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = valueOne + valueTwo;
            Console.WriteLine($"O resultado da soma é: {result}");

            Console.ReadKey();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valueOne = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Primeiro Valor: ");
            float valueTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = valueOne - valueTwo;
            Console.WriteLine($"O resultado da subtração é {result}");

            Console.ReadKey();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valueOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valueTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = (float)valueOne / (float)valueTwo;
            Console.WriteLine($"O resultado da divisão é: {result}");
        }
    }
}

