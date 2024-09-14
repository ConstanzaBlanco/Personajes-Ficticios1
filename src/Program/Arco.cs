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

    public double Usar()
    {
        if (this.flechas>0)
        {
            this.flechas -= 1;
        }
        if(this.flechas<=0)
        {
            this.danio = 0;
        }
        
        return this.danio;
    }
}