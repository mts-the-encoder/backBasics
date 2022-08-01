using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Utils
    {
        public static bool IsBigger(this int param, int secondParam)
        {
            return param > secondParam;
        }

        public static int MultiplyFor100(this int param)
        {
            return param * 100;
        }

        public static void PayWithCard(this Acc acc)
        {
            Console.WriteLine("pagando minha conta com cartão");
        }
    }
}
