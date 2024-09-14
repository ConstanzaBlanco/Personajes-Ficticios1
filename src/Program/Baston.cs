namespace Program;

public class Baston
{
    private int danio;
    private int vida;
    private int defensa;
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

    public int GetDefensa()
    {
        return this.defensa;
    }

    public int GetVida()
    {
        return this.vida;
    }
    public Baston()
    {
        this.danio = 15;
    }
}