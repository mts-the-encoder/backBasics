using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.UtcNow;

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timeZones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(data, timezone));
                Console.WriteLine("------------------");
            }


            //Console.WriteLine(data);

            //Console.WriteLine(data.ToLocalTime());

            //var timeZoneAustralia =
            //TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            //var hourAustralia =
            //TimeZoneInfo.ConvertTimeFromUtc(data, timeZoneAustralia);

            //Console.WriteLine(timeZoneAustralia); 
            //Console.WriteLine(hourAustralia);

            //var format = String.Format("{0:yyyy-MM-dd hh:mm:ss}", data);
            //var formatt = String.Format("{0:t}", data);
            //var formatt = String.Format("{0:D}", data);
            //var formatt = String.Format("{0:f}", data);
            //var formatt = String.Format("{0:r}", data);
            //var format = $"{data}";
            //Console.WriteLine(formatt);

            //Console.WriteLine(data.AddDays(12));
            //Console.Write(data.AddMonths(1));
            //Console.WriteLine(data.AddYears(1));

            //if (data.Date == DateTime.Now.Date)
            //{
            //    Console.WriteLine("è igual");
            //}

            //Console.WriteLine(data);
            //var current = CultureInfo.CurrentCulture;

            // !Important
            //var pt = new CultureInfo("pt-BR");
            //Console.WriteLine(DateTime.Now.ToString("f", pt));

        }
    }
}