using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class AgeStatisticProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> person)
        {
            IEnumerator<Person> personEnum = person.GetEnumerator();
            personEnum.MoveNext();
            Person oldestPerson = personEnum.Current;
            Person youngestPerson = personEnum.Current;
            double sumAge = personEnum.Current.Age();
            int counter = 1;

            while (personEnum.MoveNext())
            {
                sumAge += personEnum.Current.Age();
                if (oldestPerson.BirthDate > personEnum.Current.BirthDate)
                {
                    oldestPerson = personEnum.Current;
                }

                if (youngestPerson.BirthDate < personEnum.Current.BirthDate)
                {
                    youngestPerson = personEnum.Current;
                }
                counter++;
            } 

            Console.WriteLine($" \n####### Age info ########   \nAverage age: {sumAge / counter} years \nOldest person: {oldestPerson.FullName()} -- {oldestPerson.Age()} \nYoungest person: {youngestPerson.FullName()} -- {youngestPerson.Age()} \n");
        }
    }
}
