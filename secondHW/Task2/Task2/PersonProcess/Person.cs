using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Person
    {
        DateTime Today = DateTime.Today;
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public virtual decimal HourRate { get; set; }


        public Person()
        {           
            FirstName = " ";
            SecondName = " ";
            HourRate = 0;
            BirthDate = new DateTime(1950, 01, 01);

        }
        public Person(string Name, string SurName, decimal HourRate, DateTime dateTime)
        {
            FirstName = Name;
            SecondName = SurName;
            this.HourRate = HourRate;
            BirthDate = dateTime;

        }


        public int Age()
        { 
            return CountAge(BirthDate);
        }

        public string FullName()
        {
            string Name = FirstName + " " + SecondName;

            return Name;
        }
        public static int CountAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age;
            if (today.Month > birthDate.Month || ((today.Month == birthDate.Month) && (today.Day > birthDate.Day)))
            {
                age = today.Year - birthDate.Year;
            }
            else
            {
                age = (today.Year - birthDate.Year) - 1;
            }
            return age;
        }
        public decimal OverallEarnings
        {
            get
            {
                int month = ((DateTime.Today.Year * 12 + DateTime.Today.Month) - ((BirthDate.Year + 18) * 12 + BirthDate.Month));
                return month * 160 * HourRate;
            }

        }
        
        public string GetPersonalInfo()
        {
            if (Age() < 18)
            {
                return ($"\nName: {FullName()} < IT`S CHILD >  \nBirthDate: {BirthDate.ToShortDateString()} \nAge: {Age()} \nRate: {HourRate = 0} $ \nSalary: {OverallEarnings} $ \n...................\n");
            }
            return ($"\nName: {FullName()}  \nBirthDate: {BirthDate.ToShortDateString()} \nAge: {Age()} \nRate: {HourRate} $ \nSalary: {OverallEarnings} $ \n...................\n");
        }

    }
}
