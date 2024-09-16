namespace RoleplayGame;
//Separamos este item de los demas, ya que como anteriormente aclaramos algunos items tienen funcionamientos diferentes con respecto a lo otros.
public class Daga
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
    public Daga()
    {
        this.danio = 20;
    }
}