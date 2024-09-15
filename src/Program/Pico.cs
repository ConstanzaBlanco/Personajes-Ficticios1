namespace RoleplayGame;

public class Pico
{
    private int danio;
    public int Danio
    {
        get { return this.danio; }
    }
    
    public int GetAtaque()
    {
        return this.danio;
    }
    public Pico()
    {
        this.danio = 40;
    }
}