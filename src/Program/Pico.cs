namespace RoleplayGame;
//Este item solo realiza daño al ser utilizado, no se desgasta ni gana poder con cada uso
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