using System;

namespace ConsoleApp1
{
    class Jugador
    {
        protected int vida;
        public int Vida => vida;

        protected readonly Random rnd = new();

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
                vida += 10;
                dañoMinimo += 2;
                dañoMaximo += 2;
            }
        }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Nivel = 1;
            vida = 50;
            dañoMinimo = 1;
            dañoMaximo = 3;
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
            Nivel++;
            Console.WriteLine($"{Nombre} ha subido al nivel {Nivel}!");
        }
    }

    class Paladin(string nombre) : Jugador(nombre)
    {
        public virtual int Martillazo()
        {
            Console.WriteLine($"{Nombre} ha usado MARTILLAZOOOO!");
            int ataque = 20;
            return ataque;
        }
    }

    class Soldado(string nombre) : Jugador(nombre)
    {
        public virtual int Metralleta(Enemigo enemigo)
        {
            int ataque = 0;
            int ataqueTotal = 0;

            for (int i = 0; i < 4; i++)
            {
                ataque = rnd.Next(1, 4);
                ataqueTotal = +ataque;
                enemigo.RecibirDaño(ataque);
            }
            return ataqueTotal;
        }
    }

}