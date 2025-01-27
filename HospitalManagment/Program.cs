namespace HospitalManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            var dataContext =new DataContext(); 
            do
            {
                Console.WriteLine("Enter command for serching (exit for quit)");
                command = Console.ReadLine();
                switch (command)
                {
                    case "add patient":
                        Console.Write("Add Patient:");
                        dataContext.AddPatient();
                        break;
                    case "print patient":
                        dataContext.PrintPatient();
                        break;
                    case "print patients":
                        dataContext.PrintPatients();
                        break;
                    case "add doctor":
                        dataContext.AddDoctor();
                        break;
                    case "print doctor":
                        dataContext.PrintDoctors();
                        break;
                    case "add session":
                        dataContext.AddSession();
                        break;
                    case "print session":
                        dataContext.PrintSession();
                        break;
                }
            } while (command!="exit");
        }
    }
}
