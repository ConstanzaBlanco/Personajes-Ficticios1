using System.Collections.Generic;

namespace RoleplayGame
{
    public class Personaje
    {
        public string Nombre { get; }
        public string tipo {get; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        
        // Inicializa las listas de objetos
        public List<object> ItemsUtilizables { get; } = new List<object>();
        public List<object> Inventario { get; } = new List<object>();
        
        public Personaje(string nombre, int tipo)
        {
            this.Nombre = nombre;
            
            if (tipo == 1) // Mago
            {
                Mago magonuevo = new Mago();
                this.Vida = magonuevo.VidaMago();
                this.Ataque = magonuevo.AtaqueMago();
                this.Defensa = magonuevo.DefensaMago();
                this.ItemsUtilizables.AddRange(magonuevo.ItemsMago());
                this.tipo = "Mago";
            }
            else if (tipo == 2) // Elfo
            {
                Elfo elfonuevo = new Elfo();
                this.Vida = elfonuevo.VidaElfo();
                this.Ataque = elfonuevo.AtaqueElfo();
                this.Defensa = elfonuevo.DefensaElfo();
                
                // Agrega los ítems del Elfo a la lista
                this.ItemsUtilizables.AddRange(elfonuevo.ItemsElfo());
                this.tipo = "Elfo";
            }
            else if (tipo == 3) // Enano
            {
                Enano enanonuevo = new Enano();
                this.Vida = enanonuevo.VidaEnano();
                this.Ataque = enanonuevo.AtaqueEnano();
                this.Defensa = enanonuevo.DefensaEnano();
                
                // Agrega los ítems del Enano a la lista
                this.ItemsUtilizables.AddRange(enanonuevo.ItemsEnano());
                this.tipo = "Enano";
            }
            else
            {
                throw new ArgumentException("Tipo de personaje no válido.");
            }
        }

        public void AgregarItem(object item)
        {
            foreach (object itemusable in ItemsUtilizables)
            {
                if (itemusable.GetType() == item.GetType())
                {
                    Inventario.Add(item);
                }
            }
        }

        public void QuitarItem(object item)
        {
            if (this.Inventario.Contains(item))
            {
                Inventario.Remove(item);
            }
        }
    }
}
