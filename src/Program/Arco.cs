namespace Program;

public class Arco
{
    private double danio;
    private double flechas;

    public double Flechas
    {
        get { return this.flechas; }
    }
    public double Danio
    {
        get { return this.danio; }
    }

    public Arco()
    {
        this.danio = 30;
        this.flechas = 3;
    }

    public double Usar(Personaje name)
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