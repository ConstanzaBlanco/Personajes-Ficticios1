namespace RoleplayGame;
//Decidimos separar cada item en una clase diferente ya que tienen caracteristicas distintas, por ejemplo esta clase Arco
//depende de saber cuantas flechas le quedan para saber si el daño sera infringido o no.
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
            Console.WriteLine($"A {name.Nombre} ya no le quedan flechas, utiliza unicamente su Arco");
        }
        
        return this.danio;
    }
    
    public Arco()
    {
        this.danio = 30;
        this.flechas = 3;
    }
}