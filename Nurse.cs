using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueueueueue
{ 
    class Nurse : Person
    {
        public int WorkHours;
        public Patient patient;

        public Nurse(string _firstName, string _lastName, string _gender, int _workHours)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Gender = _gender;
            this.Role = "Nurse";
            this.WorkHours = _workHours;
            this.Vaccinated = true;
        }

        public void getVaccine(Patient patient)
        {
            patient.Vaccinated = true;
            WorkHours++;
        }

        public void CheckWorkTime()
        {
            if (WorkHours > 12)
            {
                Console.WriteLine("Go home and get some sleep.");
            }
            else
            {
                Console.WriteLine("Keep working you lazy bum!");
            }
        }
    }
}
