using System;
using System.Collections.Generic;

namespace ÖvningQueueueueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor who = new Doctor("Anas", "Who", "Male", 80000);
            Nurse Joy = new Nurse("Joy", "Who", "Female", 9);
            Patient P1 = new Patient("Alvin", "VetInte", "Male", "Scurvy");
            Patient P2 = new Patient("Leo", "Frid", "Male", "Healthy");
            Patient P3 = new Patient("Patrik", "Skattberg", "Male", "Healthy");
            Patient P4 = new Patient("Tim", "Nilsson", "Male", "Leprosy");
            Patient P5 = new Patient("Alfred", "Alfredsson", "Male", "Covid19");
            Patient P6 = new Patient("Theo", "Esberg", "Male", "Too many hamburgers"); 
            Patient P7 = new Patient("Petter", "Boström", "Male", "Healthy"); 
            Patient P8 = new Patient("Charlie", "Singer", "Male", "Healthy"); 
            Patient P9 = new Patient("Tobias", "Qlok", "Male", "Healthy");
            List<Patient> PList = new List<Patient>();
            PList.Add(P1);
            PList.Add(P2);
            PList.Add(P3);
            PList.Add(P4);
            PList.Add(P5);
            PList.Add(P6);
            PList.Add(P7);
            PList.Add(P8);
            PList.Add(P9);
            Queue<Patient> VaxQueue = new Queue<Patient>();
            foreach (Patient item in PList)
            {
                if (item.Disease == "Healthy")
                {
                    VaxQueue.Enqueue(item);
                }
            }
            for (int i = VaxQueue.Count; i > 0; i --)
            {
                Joy.getVaccine(VaxQueue.Dequeue());

            }
            foreach (Patient item in PList)
            {
                if (item.Vaccinated)
                {
                    item.Departure = DateTime.Now;
                    Console.WriteLine($"{item.FirstName} is vaccinated\nLeft the hospital at {item.Departure}"); 
                }
            }
            Joy.CheckWorkTime();
        }
    }
}
