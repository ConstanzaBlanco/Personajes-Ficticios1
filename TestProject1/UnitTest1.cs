using NUnit.Framework;
using RoleplayGame;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void AtacarTest()
        {
            Accion accion = new Accion();

            // Inicialización de personajes
            Personaje mago1 = new Personaje("Voldemort", 1);  // Vida inicial: 70
            Personaje enano1 = new Personaje("Aragorn", 3); // Vida inicial: 120
            Escudo escudo = new Escudo(); 
            Pocion pocion = new Pocion(); 
            Baston baston = new Baston();
            mago1.AgregarItem(pocion);
            mago1.AgregarItem(baston);
            enano1.AgregarItem(escudo);

            // Simula un ataque
            accion._Atacar_(mago1, enano1, baston);
            int vidaEsperada = 110; 
            int vidaReal = enano1.Vida;
            Assert.AreEqual(vidaEsperada, vidaReal);
        }

        [Test]
        public void Defender()
        {
            Accion accion = new Accion();

            // Inicialización de personajes
            Personaje Elfo1 = new("Zelda", 2); // Vida inicial: 90
            Personaje mago1 = new Personaje("Voldemort", 1); // Vida inicial: 70
            
            Escudo escudo = new Escudo();
            Pocion pocion = new Pocion();
            Baston baston = new Baston();
            Elfo1.AgregarItem(escudo);
            mago1.AgregarItem(pocion);
            mago1.AgregarItem(baston);

            // Simula un ataque
            accion._Defender_(Elfo1, escudo);
            accion._Atacar_(mago1, Elfo1, baston);
            int vidaEsperada = 90; //Tiene la misma vida puesto que su defensa es mayor al ataque recibido 
            int vidaReal = Elfo1.Vida;
            Assert.AreEqual(vidaEsperada, vidaReal);
        }
        [Test]
        public void CurarTest()
        {
            Accion accion = new Accion();

            // Inicialización de personajes
            Personaje Elfo1 = new ("Zelda", 2); // Vida inicial: 90
            Personaje mago1 = new Personaje("Voldemort", 1);  // Vida inicial: 80
            Personaje enano1 = new Personaje("Aragorn", 3); // Vida inicial: 120
            Espada espada = new Espada(); 
            Escudo escudo = new Escudo(); 
            Pocion pocion = new Pocion(); 
            Baston baston = new Baston();
            mago1.AgregarItem(pocion);
            mago1.AgregarItem(baston);
            enano1.AgregarItem(escudo);
            Elfo1.AgregarItem(espada);

            // Simula un ataque
            accion._Atacar_(Elfo1, mago1, espada);
            accion._Curar_(mago1, pocion);
            int VidaEsperada = 95;
            int VidaReal = mago1.Vida;
            Assert.AreEqual(VidaReal,VidaEsperada);
        }

        [Test]
        public void CurarMaximoTest()
        {
            Accion accion = new Accion();
            
            //Inicializacion de personaje
            Personaje Mago2 = new Personaje("Magnifico", 1);//Crea un Mago con vida inicial 80
            Pocion pocion_curativa = new Pocion();
            Mago2.AgregarItem(pocion_curativa);
            accion._Curar_(Mago2,pocion_curativa);//Cura vida a 110
            accion._Curar_(Mago2,pocion_curativa);

            //Este test sirve para ver si se cumple con que el maximo de vida sea 120
            int VidaEsperada = 120;
            int VidaReal = Mago2.Vida;
            Assert.AreEqual(VidaEsperada,VidaReal);

        }
    }
    
}