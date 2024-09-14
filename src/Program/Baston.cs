namespace Program;

public class Baston
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

    public Baston()
    {
        this.danio = 15;
    }
}