using RoleplayGame;

namespace ARoleplayGame;

public class Accion
{
    private CalculosDeCombate calculos = new CalculosDeCombate();
    
    public void Atacar(Personaje atacante, Personaje defensor, object item)
    {
    int ataque = 0;
    ataque = calculos.GetAtaquefinal(atacante, item);
    if (defensor.Defensa + defensor.Vida <= ataque)
    {
        defensor.Defensa = 0;
        defensor.Vida = 0;
        Console.WriteLine($"{defensor.Nombre} ha muerto por {atacante.Nombre}");
        //Agregar estado muerto
    }
    else if (defensor.Defensa <= ataque)
    {
        defensor.Vida -= ataque - defensor.Defensa;
        defensor.Defensa = 0;
        Console.WriteLine($"{defensor.Nombre} ha sido atacado por {atacante.Nombre}, perdiendo totalmente su defensa");
    }
    else if (defensor.Defensa > ataque)
    {
        defensor.Defensa -= ataque;
        Console.WriteLine($"{defensor.Nombre} ha sido atacado por {atacante.Nombre} pero su defensa no se ha roto");
    }
    }
    public void Defender(Personaje defensor, object item)
    {
        int defensa = calculos.GetDefensaTotal(defensor, item);
        defensor.Defensa += defensa;
        Console.WriteLine($"{defensor.Nombre} ha activado su defensa");
    }

    public void Curar(Personaje defensor, object item)
    {
        int salud = calculos.GetVida(defensor, item);
        if (salud + defensor.Vida <= 120)
        {
            defensor.Vida += salud;
            Console.WriteLine($"{defensor.Nombre} se ha curado");
        }
        else
        {
            defensor.Vida = 120;
            Console.WriteLine($"{defensor.Nombre} se ha curado al máximo");
        }
        
    }
}