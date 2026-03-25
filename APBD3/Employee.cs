namespace APBD3;

public class Employee : User
{
    public override int MaxRentalLimit => 5;

    public Employee(string fname, string lname) : base(fname, lname)
    {
    }
}