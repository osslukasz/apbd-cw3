namespace APBD3;

public abstract class Sprzet
{
    public Guid Id { get; } =  Guid.NewGuid();
    public string Nazwa { get; set; }
    public bool Dostepny { get; set; } = true;

    protected Sprzet(string nazwa) => Nazwa = nazwa;
}