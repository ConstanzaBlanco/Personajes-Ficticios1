namespace Program;

public class Libro
{
    private int danio;
    private int usar;
    
    public int Danio
    {
        get {return this.danio; }
        
    }

    public int Usar()
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
