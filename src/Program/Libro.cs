namespace RoleplayGame;

public class Libro
{
    private int danio;
    private int defensa;
    private int vida;
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

    public Libro()
    {
        this.danio = 15;
        this.defensa = 0;
        this.vida = 0;
    }
}