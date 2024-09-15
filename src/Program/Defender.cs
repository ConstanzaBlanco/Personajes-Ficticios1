namespace RoleplayGame;

public class Defender
{
    private CalculosDeCombate calculos = new CalculosDeCombate();

    public void Defender_(Personaje defensor, object item)
    {
        if (defensor.Inventario.Contains(item))
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