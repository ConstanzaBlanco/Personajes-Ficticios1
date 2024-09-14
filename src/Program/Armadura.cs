namespace Program;

public class Armadura
{
    private int proteccion;
    private int usos;

    public int Proteccion
    {
        get { return this.proteccion; }
    }

    public int Usar(Personaje name)
    {
        if (this.usos <= 2)
        {
            this.proteccion -= 20;
            this.usos += 1;
        }

        if (this.proteccion <= 0)
        {
            Console.WriteLine($"A {name.Nombre} se le ha roto la Armadura");
            this.proteccion = 0;
        }
        return this.proteccion;
    }
    public Armadura()
    {
        this.proteccion = 60;
        this.usos = 0;
    }
}