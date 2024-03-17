using System;

namespace ConsoleApp1
{
    abstract class Enemigo
    {
        protected int vida;
        public int Vida => vida;
        protected readonly Random rnd = new();

        private readonly int dañoMinimo;
        private readonly int dañoMaximo;
        public string Nombre { get; }

        public Enemigo(string nombre, int vidaMin, int vidaMax, int dañoMinimo, int dañoMaximo)
        {
            Nombre = nombre;
            vida = rnd.Next(vidaMin, vidaMax + 1);
            this.dañoMinimo = dañoMinimo;
            this.dañoMaximo = dañoMaximo;
        }

        public virtual int Ataque()
        {
            int ataque = rnd.Next(dañoMinimo, dañoMaximo + 1);
            Console.WriteLine($"{Nombre} te ha hecho {ataque} puntos de daño."); 
            return ataque;
        }

        public void RecibirDaño(int daño)
        {
            vida -= daño;
            if (vida <= 0)
            {
                Console.WriteLine($"{Nombre} ha sido derrotado!"); 
            }
            else
            {
                Console.WriteLine($"{Nombre} ahora tiene {vida} vida."); 
            }
        }
    }

    class Goblin : Enemigo
    {
        public Goblin() : base("Goblin", 5, 10, 1, 5)
        {
        }

        public override int Ataque()
        {
            int ataqueBase = base.Ataque();
            if (ataqueBase == 5)
            {
                int ataqueConHabilidad = ataqueBase + 2;
                Console.WriteLine($"{Nombre} utiliza su habilidad especial Garrote de Goblin y añade 2 puntos de daño extra!"); 
                Console.WriteLine($"Total: {ataqueConHabilidad} puntos de daño."); 
                return ataqueConHabilidad;
            }
            return ataqueBase;
        }
    }
}