namespace Program;

public class Armadura
{
    private double proteccion;
    private double usos;

    public double Proteccion
    {
        get { return this.proteccion; }
    }

    public double Usar()
    {
        if (this.usos <= 2)
        {
            this.proteccion -= 20;
            this.usos += 1;
        }

        return this.proteccion;
    }
    public Armadura()
    {
        this.proteccion = 40;
        this.usos = 0;
    }
}