namespace RoleplayGame;

public class ImpresionEstadoPersonaje
{
    public void ImprimirEstado(Personaje personaje)
    {
        Console.WriteLine($"El personaje {personaje.Nombre} tiene las siguientes caracteristicas:");
        Console.WriteLine($"Es de tipo: {personaje.tipo}");
        Console.WriteLine($"Tiene actualmente {personaje.Vida} de vida");
        Console.WriteLine($"Tiene actualmente {personaje.Ataque} de daño físico base");
        Console.WriteLine($"Tiene actualmente {personaje.Defensa} de defensa");
        foreach (object item in personaje.Inventario)
        {
            Console.WriteLine($"Tiene a su disposición el item: {item.GetType().ToString()}");
        }
        Console.WriteLine("");
    }
}