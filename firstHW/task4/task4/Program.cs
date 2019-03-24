using System;
using System.Collections.Generic;
using System.Linq;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello,,,,    i am Max Deineka";

            Console.WriteLine(wordsCounter(text));
            Console.ReadKey();
        }
        static int wordsCounter(string t) {
            int count = 0;
            string[] arr = new string[] { };
            arr = t.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            count = arr.Length;
            return count;
        }
    }
}
 