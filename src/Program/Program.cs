namespace RoleplayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje Mago_1 = new Personaje("Juancito", 1);
            Pocion pocion_del_amor = new Pocion();
            Mago_1.AgregarItem(pocion_del_amor);
            Personaje Elfo_1 = new Personaje("Alan", 2);
            Elfo_1.AgregarItem(pocion_del_amor);
            
        }
    }
}