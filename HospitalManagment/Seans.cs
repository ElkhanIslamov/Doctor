using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment
{
    public class Seans
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public Doctor Doctors { get; set; } 
            public Patient[] Patients { get; set; } = new Patient[20];

        public Seans(int id, string name, Doctor doctor, Patient[] patient)
        {
            Id = id;
            Name = name;
            Doctors = doctor;
            Patients = patient;
        }

        public override string ToString()
            {
                return Name;
            }

        }
    }

