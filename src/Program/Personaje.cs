using System.Runtime.CompilerServices;

namespace RoleplayGame;

public class Personaje
{
    private string nombre;
    public string Nombre { get; }

    private string tipo;
    public string Tipo { get; }
    private int vida;
    public int Vida { get; set; }
    
    private int ataque;
    public int Ataque { get; set; }
    
    private int defensa;
    public int Defensa { get; set; }

    private List<object> itemsutilizables;
    public List<object> ItemsUtilizables { get; }

    private List<object> inventario;
    
    public List<object> Inventario { get; }
    
    public Personaje(string nombre, int tipo)
    {
        this.Nombre = nombre;
        if (tipo == 1) //Mago
        {
            Mago magonuevo = new Mago();
            this.vida = magonuevo.VidaMago();
            this.ataque = magonuevo.AtaqueMago();
            this.defensa = magonuevo.DefensaMago();
            this.itemsutilizables = magonuevo.ItemsMago();
            this.tipo = "Mago";
        }
        else if (tipo == 2) //Elfo
        {
            Elfo elfonuevo = new Elfo();
            this.vida = elfonuevo.VidaElfo();
            this.ataque = elfonuevo.AtaqueElfo();
            this.defensa = elfonuevo.DefensaElfo();
            this.itemsutilizables = elfonuevo.ItemsElfo();
            this.tipo = "Elfo";
        }
        else if  (tipo == 3) //Enano
        {
            Enano enanonuevo = new Enano();
            this.vida = enanonuevo.VidaEnano();
            this.ataque = enanonuevo.AtaqueEnano();
            this.defensa = enanonuevo.DefensaEnano();
            this.itemsutilizables = enanonuevo.ItemsEnano();
            this.tipo = "Enano";
        }
        else
        {
            throw new ArgumentException("Tipo de personaje no válido.");
        }
    }

    public void AgregarItem(object item)
    {
        if (ItemsUtilizables.Contains(item))
        {
            Inventario.Add(item);
        }
    }

    public void QuitarItem(object item)
    {

        if (this.inventario.Contains(item))
        {
            Inventario.Remove(item);
        }
    }
}
