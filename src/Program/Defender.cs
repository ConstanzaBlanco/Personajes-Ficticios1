namespace RoleplayGame;
//Esta clase la separamos de las demas acciones para que cumpla correctamente con SRP, al solo enfocarse en la accion Defender
public class Defender
{
    private CalculosDeCombate calculos = new CalculosDeCombate();

    public void Defender_(Personaje defensor, object item)
    {
        if (defensor.GetInventario().Contains(item))
        {
            int defensa = calculos.GetDefensaTotal(defensor, item);
            defensor.Defensa = defensa;
            Console.WriteLine($"{defensor.Nombre} ha activado su defensa");
        }
        else
        {
            Console.WriteLine($"{defensor.Nombre} no tiene este item");
        }
    }
}
