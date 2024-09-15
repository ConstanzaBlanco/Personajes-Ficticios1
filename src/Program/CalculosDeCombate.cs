namespace  RoleplayGame;

public class CalculosDeCombate
{
    public int GetAtaquefinal(Personaje personaje, object arma)
    {
        int ActualAttack = 0;
        if (arma.GetType() == typeof(Arco))
        {
            Arco arco = (Arco)arma;
            ActualAttack = arco.GetAtaque(personaje);
        }
        else if (arma.GetType() == typeof(Espada))
        {
            Espada espada = (Espada)arma;
            ActualAttack = espada.GetAtaque();
        }
        else if (arma.GetType() == typeof(Daga))
        {
            Daga daga = (Daga)arma;
            ActualAttack = daga.GetAtaque();
        }
        else if (arma.GetType() == typeof(Baston))
        {
            Baston baston = (Baston)arma;
            ActualAttack = baston.GetAtaque();
        }
        else if (arma.GetType() == typeof(Libro))
        {
            Libro libro = (Libro)arma;
            ActualAttack = libro.GetAtaque();
        }
        else if (arma.GetType() == typeof(Pico))
        {
            Pico pico = (Pico)arma;
            ActualAttack = pico.GetAtaque();
        }
        if (ActualAttack == 0)
        {
            ActualAttack = personaje.Ataque;
        }
        return ActualAttack;
    }
    public int GetDefensaTotal(Personaje personaje,object item)
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
    public int GetVida(Personaje personaje, object arma)
    {
        int VidaActual = 0;
        foreach (object item in personaje.ItemsUtilizables)
        {
            if (arma.GetType() == typeof(Pocion))
            {
                Pocion pocion = (Pocion)arma;
                VidaActual = pocion.GetVida;
            }
        }
        if (VidaActual == 0)
        {
            VidaActual = personaje.Vida;
        }
        return VidaActual; 
    }

}