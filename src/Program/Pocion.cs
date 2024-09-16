namespace RoleplayGame;
//La Pocion es el unico item del juego capaz de curar al Persoaje Mago, elcua l a su vez es el unico que tiene la habilidad de curarse.
public class Pocion
{
    private int vida;

    public int GetVida
    {
        get {return this.vida; }
        
    }

    public Pocion()
    {
        this.vida = 30;
    }
}