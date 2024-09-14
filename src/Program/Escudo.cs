namespace Program;

public class Escudo
{
    private int danio;
    private int defensa;
    private int vida;

    public int Defensa
    {
        get { return this.defensa; }
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

    public Escudo()
    {
        this.defensa = 30;
        this.danio = 0;
        this.vida = 0;
    }
}