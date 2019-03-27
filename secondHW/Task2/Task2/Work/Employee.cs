using System;

namespace Task2
{
    class Employee : Person
    {

        public Employee(string Name, string SurName, decimal HourRate, DateTime dateTime) : base(Name, SurName, HourRate, dateTime)
        {
            FirstName = Name;
            SecondName = SurName + " EMPLOYEE";
            this.HourRate = HourRate;
            BirthDate = dateTime;

        }
        public override decimal HourRate
        {
            get
            {
                return base.HourRate * Convert.ToDecimal(1.1);
            }
        }
    }
}
