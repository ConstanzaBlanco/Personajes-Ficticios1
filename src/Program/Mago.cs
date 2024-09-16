namespace RoleplayGame;
//Al Mago lo separamos de Elfo y Enano, ya que tiene carateristicas iniciales diferentes y utilizan items diferentes.
public class Mago
{
    private int vida = 80;

    public int VidaMago()
    {
        return this.vida;
    }
    private int ataque = 5;

    public int AtaqueMago()
    {
        return this.ataque;
    }

    private int defensa = 10;
    public int DefensaMago()
    {
        return this.defensa;
    }

    private List<object> ItemsUtilizables = new List<object>
    {
        new Libro(),
        new Baston(),
        new Pocion()
    };
    public List<object> ItemsMago()
    {
        return this.ItemsUtilizables;
    }
}