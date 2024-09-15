namespace RoleplayGame;

public class Curar
{
    private CalculosDeCombate calculos = new CalculosDeCombate();

    public void Curar_(Personaje defensor, object item)
    {
        int salud = calculos.GetVida(defensor, item);

        if (defensor.Inventario.Contains(item))
        {
            if (item.GetType() == typeof(Pocion))
            {
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
            else
            {
                Console.WriteLine($"{item} no es un item para curar a {defensor.Nombre}");
            }
        }
        else
        {
            Console.WriteLine($"{defensor.Nombre} no tiene este item");
        }
    }
}