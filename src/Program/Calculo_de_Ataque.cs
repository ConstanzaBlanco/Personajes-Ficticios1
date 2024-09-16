namespace RoleplayGame;
//Separamos los Diferentes calculos de combate en Ataque, Vida y Defensa, para cumplir correctametente con el principio de SRP y una mayor organizacion.
public class Calculo_de_Ataque
{
    public int GetAtaqueFinal_(Personaje personaje, object arma)
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
    
}