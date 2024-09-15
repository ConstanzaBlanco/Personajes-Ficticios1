﻿namespace RoleplayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo 1 = Mago
            Personaje Mago_1 = new Personaje("Dumbledore", 1);
            Libro librito = new Libro();
            Baston baston_viejo = new Baston();
            Mago_1.AgregarItem(librito);
            Mago_1.AgregarItem(baston_viejo);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo 2 = Elfo
            Personaje Elfo_1 = new Personaje("Dobby", 2);
            Espada Espadadefin = new Espada();
            Escudo EscudoDelCap = new Escudo();
            Elfo_1.AgregarItem(EscudoDelCap);
            Elfo_1.AgregarItem(Espadadefin);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo 3 = Enano
            Personaje Enano_1 = new Personaje("Link", 3);
            Daga Dagadezelda = new Daga();
            Armadura armadurazelda = new Armadura();
            Enano_1.AgregarItem(Dagadezelda);
            Enano_1.AgregarItem(armadurazelda);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo1 = Mago2
            Personaje Mago_2 = new Personaje("Abracadabra", 1);
            Pocion pociondecura = new Pocion();
            Baston bastondemadera = new Baston();
            Mago_2.AgregarItem(pociondecura);
            Mago_2.AgregarItem(bastondemadera);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo2 = Elfo2
            Personaje Elfo_2 = new Personaje("Link", 2);
            Arco Arco_de_luz = new Arco();
            Escudo Hyliano = new Escudo();
            Pocion Nutricion = new Pocion();
            Elfo_2.AgregarItem(Arco_de_luz);
            Elfo_2.AgregarItem(Hyliano);
            Elfo_2.AgregarItem(Nutricion); //Como la poción no está dentro de los items de Elfo, no se añade al personaje
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo 3 = Enano2
            Personaje Enano_2 = new Personaje("Carlos", 3); 
            Pico Diamante = new Pico();
            Armadura clorofita = new Armadura();
            Enano_2.AgregarItem(Diamante);
            Enano_2.AgregarItem(clorofita);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo2 = Elfo3
            Personaje Elfo_3 = new Personaje("Zelda", 2);
            Arco Magico = new Arco();
            Escudo Ancestral = new Escudo();
            Elfo_3.AgregarItem(Magico);
            Elfo_3.AgregarItem(Ancestral);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //tipo 1 = Elfo4
            Personaje Elfo_4 = new Personaje("Ganondorf", 2);
            Espada Seis_Sabios = new Espada();
            Escudo Hierro = new Escudo();
            Elfo_4.AgregarItem(Seis_Sabios);
            Elfo_4.AgregarItem(Hierro);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //Pelea1
            Accion Pelea1 = new Accion();
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_1);
            Pelea1.Atacar(Elfo_1,Mago_1,Espadadefin);
            Pelea1.Atacar(Mago_1,Elfo_1,baston_viejo);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_1);
            Pelea1.Atacar(Mago_1,Elfo_1,librito);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_1);
            Pelea1.Defender(Elfo_1,EscudoDelCap);
            Pelea1.Atacar(Mago_1,Elfo_1,baston_viejo);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_1);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //Pelea2
            Accion Pelea2 = new Accion();
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            Pelea2.Atacar(Enano_1,Mago_2,Dagadezelda);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            Pelea2.Curar(Mago_2,pociondecura);
            Pelea2.Atacar(Mago_2,Enano_1,bastondemadera);
            Pelea2.Atacar(Enano_1,Mago_2,Dagadezelda);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            Pelea2.Defender(Mago_2,armadurazelda);
            Pelea2.Atacar(Mago_2,Enano_1,bastondemadera);
            Pelea2.Defender(Enano_1,armadurazelda);
            Console.WriteLine("Fijarse aca");
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            Pelea2.Curar(Mago_2,bastondemadera);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            Pelea2.Defender(Enano_1,armadurazelda);
            Pelea2.Atacar(Mago_2,Enano_1,bastondemadera);
            Pelea2.Atacar(Enano_1,Mago_2,Dagadezelda);
            Pelea2.Atacar(Mago_2,Enano_1,bastondemadera);
            Pelea2.Atacar(Enano_1,Mago_2,Dagadezelda);
            Pelea2.Curar(Mago_2,pociondecura);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            Pelea2.Atacar(Enano_1,Mago_2,Dagadezelda);
            Pelea2.Atacar(Mago_2,Enano_1,bastondemadera);
            Pelea2.Atacar(Enano_1,Mago_2,Dagadezelda);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_1);
            ImpresionEstadoPersonaje.ImprimirEstado(Mago_2);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //Pelea3
            Accion Pelea3 = new Accion();
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_2);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_2);
            Pelea3.Atacar(Elfo_2, Enano_2, Arco_de_luz);
            Pelea3.Defender(Enano_2,clorofita);
            Pelea3.Atacar(Enano_2,Elfo_2,Diamante);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_2);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_2);
            Pelea3.Atacar(Elfo_2,Enano_2,Arco_de_luz);
            Pelea3.Defender(Enano_2,clorofita);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_2);
            Pelea3.Curar(Enano_2,Nutricion);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_2);
            Pelea3.Defender(Elfo_2,Hyliano);
            Pelea3.Atacar(Enano_2,Elfo_2, Diamante);
            Pelea3.Atacar(Elfo_2,Enano_2,Arco_de_luz);
            ImpresionEstadoPersonaje.ImprimirEstado(Enano_2);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_2);
            Pelea3.Atacar(Enano_2,Elfo_2,Diamante);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            //Pelea4
            Accion Pelea4 = new Accion();
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_3);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_4);
            Pelea4.Atacar(Elfo_3, Elfo_4, Magico);
            Pelea4.Atacar(Elfo_4,Elfo_3,Seis_Sabios);
            Pelea4.Atacar(Elfo_3,Elfo_4,Magico);
            Console.WriteLine("Fijarse acá");
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_3);
            Pelea4.Atacar(Elfo_4,Elfo_3,Ancestral);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_3);
            Pelea4.Atacar(Elfo_3,Elfo_4,Magico);
            Pelea4.Defender(Elfo_3, Ancestral); 
            Console.WriteLine("Fijarse Acá2");
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_4);
            Pelea4.Atacar(Elfo_4,Elfo_4,Seis_Sabios);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_4);
            Pelea4.Atacar(Elfo_3,Elfo_4,Magico);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_4);
            Pelea4.Atacar(Elfo_4,Elfo_3,Seis_Sabios);
            Pelea4.Atacar(Elfo_3,Elfo_4,Magico);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_4);
            ImpresionEstadoPersonaje.ImprimirEstado(Elfo_3);
            //---------------------------------------------------------------
            //---------------------------------------------------------------
            
            
        }
    }
}