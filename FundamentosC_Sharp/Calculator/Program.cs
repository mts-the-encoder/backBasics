using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Operações disponíveis: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

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
            Console.WriteLine($"O resultado da Soma é: {result}");

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
            Console.WriteLine($"O resultado da Subtração é {result}");

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
            Console.WriteLine($"O resultado da Divisão é: {result}");

            Console.ReadKey();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valueOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valueTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = (float)valueOne * (float)valueTwo;
            Console.WriteLine($"O resultado da Multiplicação é: {result}");

            Console.ReadKey();
        }
    }
}

