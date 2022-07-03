using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float valueOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segubdo valor: ");
            float valueTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = valueOne + valueTwo;
            Console.WriteLine($"O resultado da soma é: {result}");
        } 
    }
}

