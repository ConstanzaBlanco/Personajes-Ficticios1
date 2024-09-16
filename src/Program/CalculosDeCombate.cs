namespace  RoleplayGame;
//Usamos esta clase para llamar a los distintos calculos de combate y poder tenerlos organizos en una misma clase
//para evitar confusiones a la hora de llamarlos.
public class CalculosDeCombate
{
    public int GetAtaquefinal(Personaje personaje, object arma)
    {
        Calculo_de_Ataque calculo_ataque = new Calculo_de_Ataque();
        return calculo_ataque.GetAtaqueFinal_(personaje, arma);
    }
    public int GetDefensaTotal(Personaje personaje,object item)
    {
        Calculo_de_Defensa calculo_defensa = new Calculo_de_Defensa();
        return calculo_defensa.GetDefensaFinal_(personaje, item);
    }
    public int GetVida(Personaje personaje, object arma)
    {
        Calculo_de_Vida calculo_vida = new Calculo_de_Vida();
        return calculo_vida.GetVida_(personaje, arma);
    }

}