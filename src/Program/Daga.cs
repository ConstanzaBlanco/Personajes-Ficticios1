namespace RoleplayGame;

public class Daga
{
    private int danio;
    private int defensa;
    private int vida;

    public int Danio
    {
        get { return this.danio; }
    }
    public int GetAtaque()
    {
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

    public Daga()
    {
        this.danio = 20;
        this.defensa = 0;
        this.vida = 0;
    }
}