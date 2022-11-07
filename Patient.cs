using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueueueueue
{
    public class Patient : Person
    {
        public string Disease;
        public DateTime TimeReg;
        public DateTime Departure;

        public Patient(string _firstName, string _lastName, string _gender, string _disease)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Gender = _gender;
            this.Role = "Patient";
            this.Disease = _disease;
            TimeReg = DateTime.Now;
            if(Disease == "Covid19" )
            {
                Quarantine = true;
            }
         }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Patient has {Disease} and was admitted at : {TimeReg}");
            if (Prescription)
            {
                Console.WriteLine("Patient has a prescription");
            }
            else
            {
                Console.WriteLine("Patient will be admitted ");
            }
            if (Departure != DateTime.MinValue)
            {
                Console.WriteLine($"Patient left the hospital at {Departure}.");
            }
        }
    }
}
