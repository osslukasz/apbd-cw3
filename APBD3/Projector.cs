namespace APBD3;

public class Projector: Sprzet
{
    public Projector(string nazwa, string model, string size) : base(nazwa)
    {
        this.model = model;
        this.size = size;
    }

    public string model { set; get; } 
    public string size { set; get; }
    
    
}