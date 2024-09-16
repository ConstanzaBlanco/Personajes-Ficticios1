namespace RoleplayGame;
//Separamos el Calculo de Vida de Defensa y Ataque para tener un lejor orden y cumplir con SRP.
public class Calculo_de_Vida
{
    public int GetVida_(Personaje personaje, object arma)
    {
        int VidaActual = 0;
        if (personaje.Inventario.GetInventario().Contains(arma))
        {
            foreach (object item in personaje.Inventario.ItemsUtilizables)
            {
                if (arma.GetType() == typeof(Pocion))
                {
                    Pocion pocion = (Pocion)arma;
                    VidaActual = pocion.GetVida;
                }
            }
        }
        if (VidaActual == 0)
        {
            VidaActual = personaje.Vida;
        }
        return VidaActual; 
    }
}