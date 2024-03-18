using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la leyenda de la vieja wena pal herlldiver:");
        Console.WriteLine();
        Console.WriteLine("Ingrese su nombre de jugador:");

        string nombreJugador = Console.ReadLine();
        // Jugador jugador = new(nombreJugador);

        // Paladin jugador = new(nombreJugador);
        Soldado jugador = new(nombreJugador);

        // int a = jugador.



        while (jugador.Vida > 0)
        {
            Console.WriteLine("Presiona 1 para ir al bosque");
            int posicion = Convert.ToInt32(Console.ReadLine());

            switch (posicion)
            {
                case 1:
                    Goblin goblin = new();
                    Console.WriteLine("\n=================");
                    Console.WriteLine("¡Ha aparecido un goblin!");
                    Console.WriteLine($"{jugador.Nombre}: Vida {jugador.Vida}");
                    Console.WriteLine($"{goblin.Nombre}: Vida {goblin.Vida}");

                    while (goblin.Vida > 0)
                    {
                        Console.WriteLine("Opciones: (1) Ataque - (2) Habilidad especial - (3) Huir");
                        posicion = Convert.ToInt32(Console.ReadLine());

                        int dañoJugador = 0;
                        if(posicion == 1){
                            dañoJugador = jugador.Ataque();
                        }else if(posicion == 2){
                            dañoJugador = jugador.Metralleta(goblin);
                        }
                        goblin.RecibirDaño(dañoJugador);

                        if (goblin.Vida > 0)
                        {
                            int dañoGoblin = goblin.Ataque();
                            jugador.RecibirDaño(dañoGoblin);
                        }
                        if (jugador.Vida <= 0)
                        {
                            Console.WriteLine("Has sido derrotado por el goblin. ¡Fin del juego!");
                            return;
                        }
                    }
                    jugador.SubirDeNivel();
                    break;
                case 2:
                    Console.WriteLine("HUISTE");
                    // jugador.Vida == 0;
                    break;

            }

            if (jugador.Vida > 0)
            {
                Console.WriteLine("¡Has ganado el combate!");
            }
        }
    }
}