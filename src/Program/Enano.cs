using System.Collections;

namespace RoleplayGame;
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