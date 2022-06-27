using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 100;
            float real = 25.5f;
            //real = integer;
            //integer = (int)real;
            //string realValue = real.ToString();
            //integer = int.Parse(realValue);
            integer = Convert.ToInt32(real);
            Console.WriteLine(integer);
            //Console.WriteLine(realValue);
            Console.WriteLine(Convert.ToBoolean(255));
        }
    }
}

