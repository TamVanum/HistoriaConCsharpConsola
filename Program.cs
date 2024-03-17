// See https://aka.ms/new-console-template for more information


using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la leyenda de la vieja wena pal herlldiver:");
        Console.WriteLine();
        Console.WriteLine("Ingrese su nombre de jugador:");

        string nombreJugador = Console.ReadLine();
        Jugador jugador = new(nombreJugador); // Asumiendo que la clase Jugador ahora puede instanciarse.

        // Simulación de un combate contra un Goblin
        Goblin goblin = new();

        Console.WriteLine("\n=================");
        Console.WriteLine("¡Ha aparecido un goblin!");

        while (goblin.Vida > 0 && jugador.Vida > 0)
        {
            Console.WriteLine($"{jugador.Nombre}: Vida {jugador.Vida}");
            Console.WriteLine($"{goblin.Nombre}: Vida {goblin.Vida}");

            // Asegúrate de manejar adecuadamente las excepciones para la entrada del usuario.
            while (goblin.Vida > 0)
            {
                Console.WriteLine("Opciones: (1) Ataque - (2) - (3) Huir");
                int posicion = Convert.ToInt32(Console.ReadLine());

                int dañoJugador = jugador.Ataque();
                goblin.RecibirDaño(dañoJugador);

                if (goblin.Vida > 0)
                {
                    int dañoGoblin = goblin.Ataque();
                    jugador.RecibirDaño(dañoGoblin);
                }
            }

            if (jugador.Vida <= 0)
            {
                Console.WriteLine("Has sido derrotado por el goblin. ¡Fin del juego!");
                return;
            }
        }

        if (jugador.Vida > 0)
        {
            Console.WriteLine("¡Has ganado el combate!");
        }
    }
}