using System.Collections;

namespace Program;
public class Mago
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }
    
    public Arco Arco { get; private set; }
    public Espada Espada { get; private set; }
    public Escudo Escudo { get; private set; }
    public ArrayList Items { get; set; }
    
    public Mago(string nombre, int vida, int ataque, int defensa)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
        Defensa = defensa;
        Items = new ArrayList {arco,espada,escudo };
    }
    
    public int GetVida()
    {
        return Vida; 
    }
    
    public void AgregarItems(Arco arco, Espada espada, Escudo escudo)
    {
        Items.Add(arco);
        Items.Add(espada);
        Items.Add(escudo);
    }
   
    public double GetAtaquefinal()
    {
        double ataqueTotal = Ataque;
        foreach (var item in Items)
        {
            if (item is Arco arco)
            {
                ataqueTotal += arco.Danio;
            }
            else if (item is Espada espada)
            {
                ataqueTotal += espada.Danio;
            }
        }
        return ataqueTotal;
    }
    
    public double GetDefensfinal()
    {
        double defensaTotal = Defensa;
        foreach (var item in Items)
        {
            if (item is Escudo escudo)
            {
                defensaTotal += escudo.Proteccion;
            }
        }
        return defensaTotal;
    }
}