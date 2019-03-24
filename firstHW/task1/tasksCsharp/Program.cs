using System;

namespace tasksCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(chooseBigger(a,b));
            Console.ReadKey();
            
        }
        static int chooseBigger(int x, int y)  
        {
            if (x > y)
            {
                return x;
            }
            else
                return y;
        }
    }
}
