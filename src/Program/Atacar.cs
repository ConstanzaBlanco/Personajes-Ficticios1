namespace RoleplayGame;
//Esta clase la separamos de las demas acciones para que cumpla correctamente con SRP, al solo enfocarse en la accion Atacar
public class Atacar
{
    private CalculosDeCombate calculos = new CalculosDeCombate();
    public void Atacar_(Personaje atacante, Personaje defensor, object item)
    {
        int ataque = 0;
        ataque = calculos.GetAtaquefinal(atacante, item);
        if (atacante.Nombre == defensor.Nombre)
        {
            Console.WriteLine($"No es posible que {atacante.Nombre} se ataque a si mismo");
        }
        else
        {
            if (atacante.GetInventario().Contains(item))
            {
                if (defensor.Defensa + defensor.Vida <= ataque)
                {
                    defensor.Defensa = 0;
                    defensor.Vida = 0;
                    Console.WriteLine($"{defensor.Nombre} ha sido atacado por {atacante.Nombre} con su {item.GetType().Name}");
                    Console.WriteLine($"{defensor.Nombre} ha muerto por {atacante.Nombre}");
                }
                else if (defensor.Defensa <= ataque)
                {
                    defensor.Vida -= ataque - defensor.Defensa;
                    defensor.Defensa = 0;
                    Console.WriteLine($"{defensor.Nombre} ha sido atacado por {atacante.Nombre} con su {item.GetType().Name}, perdiendo totalmente su defensa");
                }
                else if (defensor.Defensa > ataque)
                {
                    defensor.Defensa -= ataque;
                    Console.WriteLine($"{defensor.Nombre} ha sido atacado por {atacante.Nombre} con su {item.GetType().Name},pero su defensa no se ha roto");
                }
            }
            else
            {
                Console.WriteLine($"{atacante.Nombre} no tiene el item {item.GetType().Name}");
            }
        }
    }
}