namespace APBD3;

public class Student : User
{
    public override int MaxRentalLimit => 2;

    public Student(string fname, string lname) : base(fname, lname)
    {
    }
}