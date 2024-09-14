namespace Program;

public class Libro
{
    private double danio;
    private double usar;
    
    public double Danio
    {
        get {return this.danio; }
        
    }

    public double Usar()
    {
        if (this.danio<30)
        {
            this.danio += 5;
        }

        return this.danio;
    }

    public Libro()
    {
        this.danio = 15;
    }
}
