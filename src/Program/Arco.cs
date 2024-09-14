namespace RoleplayGame;

public class Arco
{
    private int danio;
    private int flechas;
    private int defensa;
    private int vida;

    public int Flechas
    {
        get { return this.flechas; }
    }
    public int Danio
    {
        get { return this.danio; }
    }
    public int GetAtaque(Personaje name)
    {
        if (this.flechas>0)
        {
            this.flechas -= 1;
        }
        if(this.flechas<=0)
        {
            this.danio = 0;
        }
        Console.WriteLine($"A {name.Nombre} le quedan {this.flechas} flechas");
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
    public Arco()
    {
        this.danio = 30;
        this.flechas = 3;
        this.defensa = 0;
        this.vida = 0;
    }
}