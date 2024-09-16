namespace RoleplayGame;
//Esta clase se diferencia en que con cada uso del Baston se le suma 5 de danio, ya que el Mago cada vez que lo usa adquiere
//una mejor habilidad de uso y por lo tanto, su daño infringido aumenta.
public class Baston
{
    private int danio;
    public int Danio
    {
        get {return this.danio; }
    }
    public int GetAtaque()
    {
        if (this.danio<30)
        {
            this.danio += 5;
        }

        return this.danio;
    }
    public Baston()
    {
        this.danio = 15;
    }
}