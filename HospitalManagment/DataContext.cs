namespace HospitalManagment
{
    internal class DataContext
    {
        public Patient[] Patients { get; set; } = new Patient[100];
        public Doctor[] Doctors { get; set; } = new Doctor[100];
        public Seans[] Seanses { get; set; } = new Seans[100];

        private int _patientIndex = 0;
        private int _doctorIndex = 0;
        private int _seansIndex = 0;


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

        public void PrintPatients()
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
        public void PrintDoctors()
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

    }
}
