using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        { 
            double x = 4;
            double y = 10;

            Console.WriteLine(calcu.sum(x,(calcu.substract(calcu.multiply(x,5),calcu.divide(y,2)))));
            Console.ReadKey();
        }
       public class calcu
        {
            public static double sum(double a, double b)
            {
                double res = a + b;
                return res;
            }
            public static double substract(double a, double b)
            {
                double res = a - b;
                return res;
            }
            public static double multiply(double a, double b)
            {
                double res = a * b;
                return res;
            }
            public static double divide(double a, double b)
            {
                double res = a / b;
                return res;
            }

        }
    }
}
