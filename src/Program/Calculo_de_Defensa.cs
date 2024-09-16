namespace RoleplayGame;
//Separamos el Calculo de Defensa de los calculos de Vida y Ataque para tener un mejor orden y cumplir con SRP.
public class Calculo_de_Defensa
{
    public int GetDefensaFinal_(Personaje personaje,object item)
    {
        int DefensaActual = 0;
        if (item.GetType() == typeof(Armadura))
        {
            Armadura armadura = (Armadura)item;
            DefensaActual += armadura.GetDefensa(personaje);
        }
        else if (item.GetType() == typeof(Escudo))
        { 
            Escudo escudo = (Escudo)item;
            DefensaActual += escudo.GetDefensa();
        }
        return DefensaActual;
    }
}