using System;

namespace StopWatch
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

            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type.Equals("m"))
            {
                multiplier = 60;
            }

            if (time.Equals(0))
            {
                System.Environment.Exit(0);
            }

            Console.WriteLine("CronomÊtro progressivo = p");
            Console.WriteLine("CronomÊtro regressivo = r");

            string counter = Console.ReadLine().ToLower();

            if (counter.Contains("p"))
            {
                Console.WriteLine("Progressivo");
                PreStartP(time);
            }
            else
            {
                Console.WriteLine("Regressivo");
                PreStartR(time);
            }
        }

        static void PreStartP(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            StartP(time);
        }

        static void PreStartR(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            StartR(time);
        }

        static void StartP(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;

                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
            Menu();
        }

        static void StartR(int time)
        {
            for (int i = 0; i < time; time--)
            {
                Console.Clear();
                Console.WriteLine(time);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
            Menu();
        }
    }
}

