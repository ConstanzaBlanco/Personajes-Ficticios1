namespace RoleplayGame;
//Seperamos los Tipos Elfo, Mago y Enano, ya que cada uno tiene valores basicos diferentes al ser de distintos tipos
//como lo son: su vida, ataque y defensa base. Tambien utilizan items diferentes, los cuales se encuentran en la lista ItemsUtilizables.
public class Enano
{
    private int vida = 120;

    public int VidaEnano()
    {
        return this.vida;
    }
    private int ataque = 15;

    public int AtaqueEnano()
    {
        return this.ataque;
    }

    private int defensa = 10;
    public int DefensaEnano()
    {
        return this.defensa;
    }

    private List<object> ItemsUtilizables = new List<object>
    {
        new Daga(),
        new Pico(),
        new Armadura()
    };

    public List<object> ItemsEnano()
    {
        return this.ItemsUtilizables;
    }
}