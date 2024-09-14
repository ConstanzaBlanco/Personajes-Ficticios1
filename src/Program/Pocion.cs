namespace Program;

public class Pocion
{
    private int vida;
    private int danio;
    private int defensa;

    public int Vida
    {
        get {return this.vida; }
        
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

    public Pocion()
    {
        this.vida = 30;
        this.danio = 0;
        this.defensa = 0;
    }
}