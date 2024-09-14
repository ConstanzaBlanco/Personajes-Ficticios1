namespace Program;

public class Personaje
{
    public string Nombre { get; set; }
    public object Tipo { get; set; } // Mago, Elfo o Enano
   

    public Personaje(string nombre, Mago tipoMago)
    {
        this.Nombre = nombre;
        this.Tipo = tipoMago;
    }
    public Personaje(string nombre, Enano tipoEnano)
    {
        this.Nombre = nombre;
        this.Tipo = tipoEnano;
    }
    public Personaje(string nombre, Elfo tipoElfo)
    {
        this.Nombre = nombre;
        this.Tipo = tipoElfo;
    }
    
}