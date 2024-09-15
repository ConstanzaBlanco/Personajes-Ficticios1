namespace RoleplayGame;

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