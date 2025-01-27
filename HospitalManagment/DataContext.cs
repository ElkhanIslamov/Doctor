using System.Text.RegularExpressions;

namespace HospitalManagment
{
    internal class DataContext
    {
        public Patient[] Patients { get; set; } = new Patient[100];
        public Doctor[] Doctors { get; set; } = new Doctor[100];
        public Session[] Sessions { get; set; } = new Session[100];

        private int _patientIndex = 0;
        private int _doctorIndex = 0;
        private int _sessionIndex = 0;

        #region Patient
        public void AddPatient()
        {
            Console.Write("Enter first name:");
            string firstname = Console.ReadLine();
            Console.Write("Enter surname:");
            string surname = Console.ReadLine();
            Console.Write("Enter gender:");
            string gender = Console.ReadLine();
            Console.Write("Enter age:");
            int age = int.Parse(Console.ReadLine());

            var patient = new Patient(firstname,surname,gender,age,_patientIndex);
            Patients[_patientIndex] = patient;
        }
        
        public void PrintPatient()
        {
            Console.Write("Search patient by id:");
            string patientId = Console.ReadLine();
            
            if (!int.TryParse(patientId, out int id))
            {
                Console.WriteLine("Not Found");
                return;
            }
            Console.WriteLine(new string('-', 80));
            if (!(id >= 0 && id <= _patientIndex))
            {
                Console.WriteLine("Not Found");
                return;
            }
            Console.WriteLine($"{"Firstname:",-20} {"Surname:",-20} {"Gender", -20} {"Age",10}");

            var patient = Patients[id];
            Console.WriteLine($"{patient.FirstName,-20} {patient.Surname,-20} {patient.Gender,-20} {patient.Age,10}");
            Console.WriteLine(new string('-', 60));
                                       
        }
        public void PrintPatients()
        {
            Console.WriteLine(new string('-', 65));
            Console.WriteLine($"{"Firstname:",-20} {"Surname:",-20} {"Gender",-20} {"Age",10}");

            foreach (var doctor in Doctors)
            {
                if (doctor == null) continue;
                Console.WriteLine($"{doctor.FirstName,-20} {doctor.Surname,-20} {doctor.Age,-5} {doctor.Speciality,15}");
            }
            Console.WriteLine(new string('-', 65));

        }
        public void PrintPatients(Patient[] patients)
        {
            Console.WriteLine(new string('-', 65));
            Console.WriteLine($"{"Firstname:",-20} {"Surname:",-20} {"Gender",-20} {"Age",10}");

            foreach (var doctor in Doctors)
            {
                if (doctor == null) continue;
                Console.WriteLine($"{doctor.FirstName,-20} {doctor.Surname,-20} {doctor.Age,-5} {doctor.Speciality,15}");
            }
            Console.WriteLine(new string('-', 65));

        }

        #endregion
        #region Doctor
        public void AddDoctor()
        {
            Console.Write("Enter name:");
            string firstname = Console.ReadLine();
            Console.Write("Enter surname:");
            string surname = Console.ReadLine();
            Console.Write("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter speciality:");
            string speciality = Console.ReadLine();

            var doctor = new Doctor(_doctorIndex, firstname, surname, age, speciality);
            Doctors[_doctorIndex] = doctor;
        }
        public void PrintDoctor()
        {
            Console.Write("Search patient by id:");
            string doctorId = Console.ReadLine();

            if (!int.TryParse(doctorId, out int id))
            {
                Console.WriteLine("Not Found");
                return;
            }
            Console.WriteLine(new string('-', 80));
            if (!(id >= 0 && id <= _doctorIndex))
            {
                Console.WriteLine("Not Found");
                return;
            }
            Console.WriteLine($"{"Firstname:",-20} {"Surname:",-20} {"Age",-20} {"Speciality",10}");

            var doctor = Doctors[id];
            Console.WriteLine($"{doctor.FirstName,-20} {doctor.Surname,-20} {doctor.Age,-20} {doctor.Speciality,10}");
            Console.WriteLine(new string('-', 60));

        }
        public void PrintDoctors()
        {
            Console.WriteLine(new string('-', 65));
            Console.WriteLine($"{"FirstName",-20} {"LastName",-20} {"Age",-5} {"Subject",15}");

            foreach (var teacher in Doctors)
            {
                if (teacher == null) continue;
                Console.WriteLine($"{teacher.FirstName,-20} {teacher.Surname,-20} {teacher.Age,-5} {teacher.Speciality,15}");
            }
            Console.WriteLine(new string('-', 65));

        }
        #endregion

        #region Session
        public void AddSession()
        {
            Console.WriteLine("Choose doctor below");
            PrintDoctors();
            Console.Write("Enter doctor Id:");
            string idString = Console.ReadLine();

            if (!int.TryParse(idString, out int doctorId) || doctorId < 0 || doctorId >= _doctorIndex)
            {
                Console.WriteLine("Doctor id is wrong");
                return;
            }

            Console.WriteLine("Enter Group name");
            string name = Console.ReadLine();
            Console.WriteLine("Choose patients below");
            PrintPatients();

            Console.Write("Enter students Id with comma:");
            var identities = Console.ReadLine().Split(",");
            var patients = new Patient[identities.Length];

            for (int i = 0; i < patients.Length; i++)
            {
                var patientId = int.Parse(identities[i]);
                patients[i] = Patients[patientId];
            }

            var doctor = Doctors[doctorId];
            var session = new Session(_patientIndex,name,doctor,patients);

            Sessions[_sessionIndex++] = session;
            foreach (var patient in patients)
            {
                patient.Session = session;
            }
        }

        public void PrintSession()
        {
            foreach (var session in Sessions)
            {
                if (session == null) continue;
                Console.WriteLine(new string('-', 70));
                Console.WriteLine("Seans:" + session.Name);
                Console.WriteLine("Doctor:" + session.Doctor.FirstName);
                Console.WriteLine("Patient:");
                Console.WriteLine($"{"FirstName",-20} {"LastName",-20} {"Age",-5} {"Seans",10}");

                PrintPatients(session.Patients);
            }
        }
        #endregion


    }
}
