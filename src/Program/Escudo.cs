namespace RoleplayGame;
//Separamos los items en clases diferentes ya que cada uno tiene funcinalidades diferentes, por ejemplo el escudo solo sirve para defender,
//no para atacar o curar. Ademas, si en un futuro se le quiere agregar alguna otra funcionalidad, se podra hacer sin problemas al estar aislado
//de los demas items.
public class Escudo
{
    private int defensa;

    public int Defensa
    {
        get { return this.defensa; }
    }
    public int GetDefensa()
    {
        return this.defensa;
    }

    public Escudo()
    {
        this.defensa = 30;
    }
}