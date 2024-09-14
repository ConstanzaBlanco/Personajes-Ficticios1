using ARoleplayGame;

namespace RoleplayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje Mago_1 = new Personaje("Juancito", 1);
            Libro LIBRITO = new Libro();
            Baston baston_viejo = new Baston();
            Mago_1.AgregarItem(LIBRITO);
            Mago_1.AgregarItem(baston_viejo);
            Personaje Elfo_1 = new Personaje("Alan", 2);
            Mago_1.QuitarItem(LIBRITO);
            Espada Espadadefin = new Espada();
            Escudo EscudoDelCap = new Escudo();
            Elfo_1.AgregarItem(EscudoDelCap);
            Elfo_1.AgregarItem(Espadadefin);
            ImpresionEstadoPersonaje Imprimir = new ImpresionEstadoPersonaje();
            Accion Pelea1 = new Accion();
            Imprimir.ImprimirEstado(Elfo_1);
            Pelea1.Atacar(Mago_1, Elfo_1, baston_viejo);
            Imprimir.ImprimirEstado(Mago_1);
            Imprimir.ImprimirEstado(Elfo_1);
            Pelea1.Defender(Elfo_1, EscudoDelCap);
            Pelea1.Atacar(Mago_1, Elfo_1, baston_viejo);
            Imprimir.ImprimirEstado(Elfo_1);
            Pelea1.Atacar(Mago_1, Elfo_1, baston_viejo);
            Imprimir.ImprimirEstado(Elfo_1);
            Pelea1.Atacar(Mago_1, Elfo_1, baston_viejo);
            Imprimir.ImprimirEstado(Elfo_1);
            Pelea1.Atacar(Mago_1, Elfo_1, baston_viejo);
        }
    }
}