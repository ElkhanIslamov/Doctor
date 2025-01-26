namespace HospitalManagment;

public class Patient
{
    public int Id { get; set; }

    internal string _firstname;
    public string FirstName 
    {
        get => _firstname;
        set => _firstname=value;
    }
    internal string _surname;
    public string Surname 
    {
        get => _surname;
        set => _surname=value;
    }
    internal string _gender;
    public string Gender 
    { 
        get =>_gender; 
        set =>_gender=value;
    }
    internal int _age;
    public int Age 
    {
        get=>_age;
        set=>_age=value;
    }
    public Patient()
    {
        
    }
    public Patient(string firstname, string surname, string gender, int age, int id)
    {
     
        _firstname = firstname;
        _surname = surname;
        _gender = gender;
        _age = age;
        Id = id;
    }
    public override string ToString()
    {
        return $"{Id} {FirstName} {Surname} {Gender} {Age}";
    }
 

}
