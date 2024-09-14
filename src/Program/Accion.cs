namespace Program;

public class Accion
{
    private double Cant_Acciones = 0;

    public double cant_acciones()
    {
        return this.Cant_Acciones;
    }
    public string Atacar(Personaje atacante, Personaje defensor, object item)
    {
        Cant_Acciones += 1;
        if (atacante.Listaitems.Countains(item))
            
    }

    
}