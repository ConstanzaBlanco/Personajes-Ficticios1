namespace RoleplayGame;

//Esta clase la utilizamos para llamar a las otras clases de Atacar,Defender y Curar, ya que estas clases son acciones
//y queda mejor organizado que las mismas sean llamadas dentro de la clase Accion para que una persona ajena al codigo
//pueda entenderlo.
public class Accion
{
    private CalculosDeCombate calculos = new CalculosDeCombate();

    public void _Atacar_(Personaje atacante,Personaje defensor, object item)
    {
        Atacar ataque = new Atacar();
        ataque.Atacar_(atacante,defensor,item);
    }
    
    public void _Defender_(Personaje defensor, object item)
    {
        Defender defensa = new Defender();
        defensa.Defender_(defensor,item);
    }

    public void _Curar_(Personaje defensor, object item)
    {
        Curar curacion = new Curar();
        curacion.Curar_(defensor,item);
    }
}