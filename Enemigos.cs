using System;

namespace ConsoleApp1
{

    class Goblin()
    {

        public readonly Random rnd = new();
        // public int Vida { get; } = vida;



        // Method to Calculate Area
        // of the rectangle
        public int Ataque()
        {
            int ataque = rnd.Next(1, 5);
            return ataque;
        }

        // public int RecibirDaño(int daño, int vida)
        // {
        //     vida -= daño;
        //     return vida;
        // }
    }
}
