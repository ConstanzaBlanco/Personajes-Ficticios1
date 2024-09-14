namespace Program;

public class Baston
{
    private double danio;
    private double usar;

    public double Danio
    {
        get {return this.danio; }
    }
    public double Usar(Accion jugadas)
    {
        if (this.danio<30)
        {
            this.danio += jugadas.cant_acciones()*2;
        }

        return this.danio;
    }

    public Baston()
    {
        this.danio = 15;
    }
}