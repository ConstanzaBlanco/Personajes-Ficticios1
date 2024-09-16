namespace RoleplayGame;
//Seperamos los Tipos Elfo, Mago y Enano, ya que cada uno tiene valores basicos diferentes al ser de distintos tipos
//como lo son: su vida, ataque y defensa base. Tambien utilizan items diferentes, los cuales se encuentran en la lista ItemsUtilizables.
public class Elfo
{
    private int vida = 90;

    public int VidaElfo()
    {
        return this.vida;
    }
    private int ataque = 15;

    public int AtaqueElfo()
    {
        return this.ataque;
    }

    private int defensa = 5;
    public int DefensaElfo()
    {
        return this.defensa;
    }

    private List<object> ItemsUtilizables = new List<object>
    {
        new Arco(),
        new Espada(),
        new Escudo()
    };

    public List<object> ItemsElfo()
    {
        return this.ItemsUtilizables;
    }
}