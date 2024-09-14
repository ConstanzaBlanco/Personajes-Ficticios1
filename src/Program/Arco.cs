namespace Program;

public class Arco
{
    private int danio;
    private int flechas;

    public int Flechas
    {
        get { return this.flechas; }
    }
    public int Danio
    {
        get { return this.danio; }
    }

    public Arco()
    {
        this.danio = 30;
        this.flechas = 3;
    }

    public int Usar(Personaje name)
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
}