using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueueueueue
{
    public class Doctor : Person
    {
        public double Salary;
        public Patient patient;
        public Doctor(string _firstName, string _lastName, string _gender, double _salary)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Gender = _gender;
            this.Salary = _salary;
            this.Role = "Doctor";
            this.Vaccinated = true;

        }
        public void TreatPatient(Patient patient)
        {
            patient.Disease = "Healthy";
            patient.Departure = DateTime.Now;
        }

        public void PrescriptionDrug(Patient patient)
        {
            patient.Prescription = true;
        }
    }
}
