namespace APBD3;

public class Laptop : Sprzet
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string Nazwa { get; set; }

    public Laptop(string nazwa, string cpu, string gpu) : base(nazwa)
    {
        CPU = cpu;
        GPU = gpu;
    }
}