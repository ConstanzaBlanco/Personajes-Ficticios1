namespace RoleplayGame;
//Este item solo infringe daño, no cura ni defiende.
public class Espada
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
    
    public Espada()
    {
        this.danio = 25;
    }
    
}