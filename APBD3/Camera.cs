namespace APBD3;

public class Camera: Sprzet
{
    public string Type { set; get; }
    public string Resolution { set; get; }

    public Camera(string nazwa, string type, string resolution) : base(nazwa)
    {
        this.Type = type;
        this.Resolution = resolution;
    }
}