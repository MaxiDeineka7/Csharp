using System;

namespace Task2
{
    class Freelancer : Person
    {

        public Freelancer(string Name, string SurName, decimal HourRate, DateTime dateTime) : base(Name,SurName,HourRate,dateTime)
        {
            FirstName = Name;
            SecondName = SurName + " FREELANCER";
            this.HourRate = HourRate;
            BirthDate = dateTime;

        }
        public override decimal HourRate
        {
            get
            {
                return base.HourRate * Convert.ToDecimal(1.5);
            }
        }
    }
}
