using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////// Task 2 - 3

            Person[] person = new PersonsGenerator().Generate(20);
            foreach (Person var in person)
            {
                Console.WriteLine(var.GetPersonalInfo());
            }

            ////////////// Task 4 - 5          

            SalaryProcessor salary = new SalaryProcessor();
            salary.Process(person);

            AgeStatisticProcessor age = new AgeStatisticProcessor();
            age.Process(person);

            NameProcessor name = new NameProcessor();
            name.Process(person);



            Console.ReadLine();
        }
    }
}
 