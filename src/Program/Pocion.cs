namespace RoleplayGame;

public class Pocion
{
    private int aumento_vida;

    public int GetVida
    {
        get {return this.aumento_vida; }
        
    }

    public Pocion()
    {
        this.aumento_vida = 30;
    }
}