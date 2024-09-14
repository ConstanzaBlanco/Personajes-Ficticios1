namespace Program;

public class Armadura
{
    private int proteccion;
    private int usos;
    private int ataque;
    private int vida;

    public int Proteccion
    {
        get { return this.proteccion; }
    }

    public int GetDefensa(Personaje name)
    {
        if (this.usos <= 2)
        {
            this.proteccion -= 20;
            this.usos += 1;
        }

        if (this.proteccion <= 0)
        {
            Console.WriteLine($"A {name.Nombre} se le ha roto la Armadura");
            this.proteccion = 0;
        }
        return this.proteccion;
    }

    public int GetAtaque()
    {
        return this.ataque;
    }

    public int GetVida()
    {
        return this.vida;
    }
    
    public Armadura()
    {
        this.proteccion = 60;
        this.usos = 0;
        this.ataque = 0;
        this.vida = 0;
    }
}