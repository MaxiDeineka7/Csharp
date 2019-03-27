using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static DateTime RandomDay(DateTime minDay, DateTime maxDay)
        {
            Random randomize = new Random();
            int range = (maxDay - minDay).Days;
            return minDay.AddDays(randomize.Next(range));
        }
        static void Main(string[] args)
        {
            DateTime minDay = new DateTime(2019, 05, 01);
            DateTime maxDay = new DateTime(2019, 05, 15);

            Console.WriteLine(RandomDay(minDay,maxDay));
            Console.ReadKey();
        }
    }
}

