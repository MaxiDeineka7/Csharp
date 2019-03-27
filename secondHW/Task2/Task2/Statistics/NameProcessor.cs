using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class NameProcessor : PersonsProcessor
    {

        public override void Process(IEnumerable<Person> person)
        {
            SortedList<string, int> nameCount = new SortedList<string, int>();
            IEnumerator<Person> personEnum = person.GetEnumerator();
            

            int count = 0;
            while (personEnum.MoveNext())
            {
                
                if (nameCount.ContainsKey(personEnum.Current.FirstName))
                {
                    nameCount[personEnum.Current.FirstName]++;                     
                }
                else
                {
                    nameCount.Add(personEnum.Current.FirstName,1);
                }
                count++;
                
            } 

            foreach(KeyValuePair<string, int> i in nameCount)
            {
                Console.WriteLine($"Name: {i.Key} -- {i.Value} times({100*i.Value/count}) %");
            }
        }
    }
}
