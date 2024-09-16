namespace RoleplayGame;
//Este item es diferente a los otros, ya que el daño que infringe depende de la cantidad de hachizos que contenga el Libro,
//para esto le pusimos un metodo de agregar hechizos a la lista de hechizos del libro, la cual sera tomada en cuenta para retornar el
//daño que causara el Libro.
public class Libro
{
    private int danio;
    private List<string> Hechizos = new List<string>();
    public int Danio
    {
        get {return this.danio; }
        
    }
    public int GetAtaque()
    {
        int cant_hechizos = Hechizos.Count;
        this.danio += cant_hechizos;
        return this.danio;
    }

    public void AgregarHechizos(string hechizo)
    {
        Hechizos.Add(hechizo);
    }

    public Libro()
    {
        this.danio = 15;
    }
}