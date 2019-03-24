using System;
using System.Collections.Generic;
using System.Linq;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 55, 6, 15, 20, 4, 9, 12, 11 };
            int minVal = array.Min();
            int maxVal = array.Max();
            var result = FilterArray(array, minVal, maxVal);
            foreach (var res in result) {
                Console.WriteLine(res);
            }
            Console.ReadKey();


        }
        public static List<int> FilterArray(int[] arr, int  min, int max) {
            List<int> res = new List<int>();

            for (int i = 1; i < arr.Length; i++) {
                if ((arr[i] > min) && (arr[i] < max)) {
                    res.Add(arr[i]);        
                }
            }
            return res;
        }
    }
}
