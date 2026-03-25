namespace APBD3;

public abstract class User
{
    public string Id { get; } = Guid.NewGuid().ToString().Substring(0, 8);
    public string Name {get; set;}
    public string LastName {get; set;}
    public abstract int MaxRentalLimit { get; }
    
    protected User(string fname, string lname)
    {
        Name = fname;
        LastName = lname;
    }
    
}