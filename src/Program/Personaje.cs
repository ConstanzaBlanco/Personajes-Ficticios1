namespace RoleplayGame
//Creamos esta clase para que tome los valores iniciales de Vida, ataque y defensa del Personaje dependiendo de su tipo.
//Siendo 1=Mago, 2=Elfo, y 3=Enano.
//En esta clase tambien podemos modificar el inventario del personaje accediendo a la Clase inventario y sus metodos.
//Cumple con SRP ya que tien la unica responsabilidad de conocer el tipo de personaje, sus caracteristicas y su inventario.
{
    public class Personaje
    {
        public string Nombre { get; }
        public string tipo {get; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        
        // Inicializa las listas de objetos
        public Inventario Inventario { get; } = new Inventario();
        
        public Personaje(string nombre, int tipo)
        {
            this.Nombre = nombre;
            
            if (tipo == 1) // Mago
            {
                Mago magonuevo = new Mago();
                this.Vida = magonuevo.VidaMago();
                this.Ataque = magonuevo.AtaqueMago();
                this.Defensa = magonuevo.DefensaMago();
                this.Inventario.ItemsUtilizables.AddRange(magonuevo.ItemsMago());
                this.tipo = "Mago";
            }
            else if (tipo == 2) // Elfo
            {
                Elfo elfonuevo = new Elfo();
                this.Vida = elfonuevo.VidaElfo();
                this.Ataque = elfonuevo.AtaqueElfo();
                this.Defensa = elfonuevo.DefensaElfo();
                
                // Agrega los ítems del Elfo a la lista
                this.Inventario.ItemsUtilizables.AddRange(elfonuevo.ItemsElfo());
                this.tipo = "Elfo";
            }
            else if (tipo == 3) // Enano
            {
                Enano enanonuevo = new Enano();
                this.Vida = enanonuevo.VidaEnano();
                this.Ataque = enanonuevo.AtaqueEnano();
                this.Defensa = enanonuevo.DefensaEnano();
                
                // Agrega los ítems del Enano a la lista
                this.Inventario.ItemsUtilizables.AddRange(enanonuevo.ItemsEnano());
                this.tipo = "Enano";
            }
            else
            {
                throw new ArgumentException("Tipo de personaje no válido.");
            }
        }

        public void AgregarItem(object item)
        {
            Inventario.AgregarItem_(item);
        }

        public void QuitarItem(object item)
        {
            Inventario.QuitarItem_(item);
        }
        public List<object> GetInventario()
        {
            return Inventario.GetInventario();
        }
    }
}
