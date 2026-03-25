namespace APBD3;

public abstract class Sprzet
{
    public string Id { get; } =  Guid.NewGuid().ToString().Substring(0, 8);
    public string Nazwa { get; set; }
    public bool Dostepny { get; set; } = true;

    protected Sprzet(string nazwa) => Nazwa = nazwa;

    protected Sprzet()
    {
        throw new NotImplementedException();
    }
}