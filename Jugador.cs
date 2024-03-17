using System;

namespace ConsoleApp1
{
    class Jugador
    {
        protected int vida;
        public int Vida => vida;

        protected readonly Random rnd = new Random();

        private int dañoMinimo;
        private int dañoMaximo;
        public string Nombre { get; }
        private int nivel;

        public int Nivel
        {
            get => nivel;
            private set
            {
                nivel = value;
                // Cada vez que el nivel aumenta, incrementa la vida y el daño.
                vida += 10; // Añade 10 a la vida total por cada nivel.
                dañoMinimo += 2; // Añade 2 al daño mínimo.
                dañoMaximo += 2; // Añade 2 al daño máximo.
            }
        }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Nivel = 1; // Inicializa el jugador en nivel 1.
            vida = 50; // Vida inicial.
            dañoMinimo = 2; // Daño mínimo inicial.
            dañoMaximo = 3; // Daño máximo inicial.
        }

        public virtual int Ataque()
        {
            int ataque = rnd.Next(dañoMinimo, dañoMaximo + 1);
            Console.WriteLine($"{Nombre} inflige {ataque} puntos de daño.");
            return ataque;
        }

        public void RecibirDaño(int daño)
        {
            vida -= daño;
            if (vida <= 0)
            {
                Console.WriteLine($"Has muerto...");
            }
            else
            {
                Console.WriteLine($"{Nombre}: ahora tienes {vida} puntos de vida.");
            }
        }

        public void SubirDeNivel()
        {
            Nivel++; // Incrementa el nivel, lo cual también incrementa la vida y el daño.
            Console.WriteLine($"{Nombre} ha subido al nivel {Nivel}!");
        }
    }
}