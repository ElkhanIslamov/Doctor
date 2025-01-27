namespace HospitalManagment;

public class Session
{
        public int Id { get; set; }
        public string Name { get; set; }
        public Doctor Doctor { get; set; }
    public Patient[] Patients { get; set; } = new Patient[10];

    public Session(int id, string name, Doctor doctor, Patient[] patients)
    {
        Id = id;
        Name = name;
        Doctor = doctor;
        Patients = patients;
    }

    public override string ToString()
        {
            return Name;
        }

    }


