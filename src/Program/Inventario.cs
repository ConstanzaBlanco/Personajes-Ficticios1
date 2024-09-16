namespace RoleplayGame;
//Separamos esta clase de Personaje, ya que tiene la responsablidad de agreagr o quitar items del inventario del Personaje,
//y tambien de devolver una copia del inventario actual de personaje
public class Inventario
{
    public List<object> inventario { get; } = new List<object>();
    public List<object> ItemsUtilizables { get; } = new List<object>();
    public void AgregarItem_(object item)
    {
        if (ItemsUtilizables.Contains(item.GetType()))
        {
            inventario.Add(item);
        }
    }

    public void QuitarItem_(object item)
    {
        if (inventario.Contains(item))
        {
            inventario.Remove(item);
        }
    }
    
    public List<object> GetInventario()
    {
        return new List<object>(inventario); 
    }
}