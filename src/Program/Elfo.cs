using System.Collections;

namespace RoleplayGame;
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