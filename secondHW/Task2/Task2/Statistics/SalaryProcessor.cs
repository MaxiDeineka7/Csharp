using System;
using System.Collections.Generic;


namespace Task2
{
    class SalaryProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> person)
        {
            IEnumerator<Person> personEnum = person.GetEnumerator();
            personEnum.MoveNext();
            Person highlyPerson = personEnum.Current;

            while (personEnum.MoveNext())
            {
                if (highlyPerson.Age() >= 18)
                {

                    if (highlyPerson.OverallEarnings < personEnum.Current.OverallEarnings) 
                    {
                        highlyPerson = personEnum.Current;
                    }
                }
               
            }  

            Console.WriteLine($"#####Highly payed person#######  \nName: {highlyPerson.FullName()} \nAge: {highlyPerson.Age()} \nOverallearnings: {highlyPerson.OverallEarnings} $  \n");
        }
    }
}

