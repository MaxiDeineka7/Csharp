using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class PersonsGenerator
    {
        public string[] Name = {"Andrew","Maxim","Nazar","Ruslan","Ann","Kate","Alex","Mary","Bryan","Mike","Bob","Rice","Kevin","Emm","Michael","Oleh","Luka","Chris","Lionel","Antony"};
        public string[] SurName = {"Deineka","Ivanov","Petrov","Martial","Messi","De Gea","Lukaku","Sidorov","Kaban","Toni","Ronaldo","Kane","Mata","Sydorenko","Shevchenko"};        

        public Person[] Generate(int amount)
        {
            List<Person> people = new List<Person>();
            Random r = new Random();
            for (int i = 0; i < amount; i++)
            {
                int NameID = new Random().Next(Name.Length);
                int SurNameID = new Random().Next(SurName.Length);

                string FirstName = Name[NameID];
                string SecondName = SurName[SurNameID];

                decimal HourRate =  r.Next(1, 100);
                DateTime BirthDate = new DateTime (r.Next(1950,2019),r.Next(1,12),r.Next(1,28));

                if (Person.CountAge(BirthDate) >=18)
                {
                    var position = r.Next(0, 3);
                    switch (position)
                    {
                        case 0:
                            people.Add(new Freelancer(FirstName, SecondName, HourRate, BirthDate));
                            break;
                        case 1:
                            people.Add(new Employee(FirstName, SecondName, HourRate, BirthDate));
                            break;
                        case 2:
                            people.Add(new Subcontractor(FirstName, SecondName, HourRate, BirthDate));
                            break;
                    }
                }
                else
                {
                    people.Add(new Person(FirstName, SecondName, HourRate, BirthDate));
                }
     
            }
            return people.ToArray();
        }
    }
}                                   
