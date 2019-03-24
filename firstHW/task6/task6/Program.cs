using System;
using System.Collections.Generic;
using System.Linq;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "HelLo MY my My nAmE iS MAX Max" ;
            string[] arr = { "my", "is" };

            
            var finish = Counter(str, arr);
            foreach (var i in finish)
            {
                Console.WriteLine(i.word + " " + i.count);
            }
            Console.ReadKey();        
        }

        public static List<Objec> Counter(string text, string[] arr)
        {
            List<Objec> result = new List<Objec>();
            text = text.ToLower();
            string[] str2 = text.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                string name = arr[i];
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str2[j] == arr[i])
                    {
                        count++;
                    }
                }               
                Objec obj = new Objec(name,count);
                result.Add(obj);
            }
            return result;
        }
        
    }
    public class Objec
    {
        public string word;
        public int count;

        public Objec(string word, int count)
        {
            this.word = word;
            this.count = count;
        }
    }
}
