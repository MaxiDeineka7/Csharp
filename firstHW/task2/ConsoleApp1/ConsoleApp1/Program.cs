using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 55, 6, 15, 20, 4, 9, 12, 11 };

            Console.WriteLine(findMax(array));
            Console.WriteLine(findMin(array));
            Console.ReadKey();
        }

        public static int findMax(int[] x)
        {
            return x.Max();
        }

        public static int findMin(int[] x)
        {
            return x.Min();
        }
    }
}
