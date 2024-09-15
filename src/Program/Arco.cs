namespace RoleplayGame;

public class Arco
{
    private int danio;
    private int flechas;

    public int Flechas
    {
        get { return this.flechas; }
    }
    public int Danio
    {
        get { return this.danio; }
    }
    public int GetAtaque(Personaje name)
    {
        if (this.flechas>0)
        {
            this.flechas -= 1;
            Console.WriteLine($"A {name.Nombre} le quedan {this.flechas} flechas");
        }
        if(this.flechas<=0)
        {
            this.danio = 0;
            Console.WriteLine($"A {name.Nombre} ya no le quedan flechas, ha dado un puñetazo");
        }
        
        return this.danio;
    }
    
    public Arco()
    {
        this.danio = 30;
        this.flechas = 3;
    }
}