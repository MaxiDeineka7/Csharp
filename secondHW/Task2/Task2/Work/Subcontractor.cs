using System;

namespace Task2
{
    class Subcontractor : Person
    {      
        public Subcontractor(string Name, string SurName, decimal HourRate, DateTime dateTime) : base(Name, SurName, HourRate, dateTime)
        {
            FirstName = Name;
            SecondName = SurName + " SUBCONTRACTOR";
            this.HourRate = HourRate;
            BirthDate = dateTime;
        }
        public override decimal HourRate
        {
            get
            {
                return base.HourRate * Convert.ToDecimal(2.2);
            }
        }
    }
}
