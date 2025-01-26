namespace HospitalManagment;

public class Doctor
{
    public int Id { get; set; }
    internal string _firstname;
    public string FirstName 
    { 
        get=>_firstname;
        set=>_firstname=value;
    }
    internal string _surname;
    public string Surname 
    { 
        get=>_surname;
        set=>_surname=value;
    }
    internal int _age;
    public int Age 
    {
        get=>_age;
        set=>_age=value;
    }
    internal string _speciality;
    public string Speciality 
    {
        get=>_speciality;
        set=>_speciality=value;
    }
    public Doctor()
    {
        
    }
    public Doctor(int id, string firstName, string surname, int age, string speciality)
    {
         Id = id;
        _firstname = firstName;
        _surname = surname;
        _age = age;
        _speciality = speciality;
    }
    public override string ToString()
    {
        return $"{FirstName} {Surname} {Age} {Speciality}";
    }

}
