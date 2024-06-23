using System;
public abstract class ClsPerson
{

    public enum EnMode { AddNew = 0, Update = 1 };
    public EnMode Mode = EnMode.AddNew;


    public int ID { get; }
    public string FirstName { set; get; }
    public string MidName { set; get; }
    public string LastName { set; get; }
    public DateTime DateOfBirth { set; get; }
    public string Email { set; get; }
    public char Gender { set; get; }
    public string Address { set; get; }


    // Defualt constructor.
    public ClsPerson()
    {
        FirstName = string.Empty;
        MidName = string.Empty;
        LastName = string.Empty;
        DateOfBirth = DateTime.Now;
        Email = string.Empty;
        Gender = ' ';
        Address = string.Empty;

        Mode = EnMode.AddNew;
    }


    // Constructor used to add (Patenit or Doctor) Object to Database.
    protected ClsPerson
        (
        int id,
        string firstName, string midName, string lastName,
        DateTime dateOfBirth, string email, char gender, string address
        )
    {
        ID = id;
        FirstName = firstName;
        MidName = midName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Email = email;
        Gender = gender;
        Address = address;

        Mode = EnMode.Update;
    }


    protected abstract bool AddNew();
    protected abstract bool Update();
    public abstract bool Save();
    public string FullName() => $"{FirstName} {MidName} {LastName}";
}