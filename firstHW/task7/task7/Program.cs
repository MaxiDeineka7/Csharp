using System;
using System.Collections.Generic;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 32, 2, 5, 14, 28, 11, 15 };

            var finish = Counter(Arr);
            foreach (var i in finish)
            {
                Console.WriteLine(i.numb + " " + i.TF);
            }
            Console.ReadKey();
        }

        public static List<Numbers> Counter(int[] arr)
        {
            List<Numbers> result = new List<Numbers>();

            for(int i=0;i < arr.Length; i++)
            {
                int numb = arr[i];
                bool TF = false;
                if ((numb % 2) != 0)
                {
                    TF = true;
                }
                Numbers t = new Numbers(numb,TF);
                result.Add(t);
            }

            return result;
        }
    }
    public class Numbers
    {
        public int numb;
        public bool TF;
        public Numbers(int numb, bool TF)
        {
            this.numb = numb;
            this.TF = TF;
        }
    }
}
