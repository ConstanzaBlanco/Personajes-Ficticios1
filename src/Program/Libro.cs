namespace RoleplayGame;

public class Libro
{
    private int danio;
    private int defensa;
    private int vida;
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
        this.defensa = 0;
        this.vida = 0;
    }
}