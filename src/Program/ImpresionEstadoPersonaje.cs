namespace RoleplayGame;
//Esta clase la implementamos para poder observar el estado actual del personaje lo cual puede ser útil para la depuración,
//pruebas, o para proporcionar una actualización al usuario, ademas lo separamos en una clase para cumplir con SRP.
public class ImpresionEstadoPersonaje
{
    public static void ImprimirEstado(Personaje personaje)
    {
        Console.WriteLine($"El personaje {personaje.Nombre} tiene las siguientes caracteristicas:");
        Console.WriteLine($"Es de tipo: {personaje.tipo}");
        Console.WriteLine($"Tiene actualmente {personaje.Vida} de vida");
        Console.WriteLine($"Tiene actualmente {personaje.Ataque} de daño físico base");
        Console.WriteLine($"Tiene actualmente {personaje.Defensa} de defensa");
        foreach (object item in personaje.GetInventario())
        {
            Console.WriteLine($"Tiene a su disposición el item: {item.GetType().Name}");
        }
        Console.WriteLine("");
    }
}