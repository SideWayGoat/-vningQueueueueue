using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueueueueue
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public string Role;
        public bool Prescription = false;
        public bool Quarantine = false;
        public bool Vaccinated = false;


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}\nRole: {Role}\nGender: {Gender}");
        }


    }
}
