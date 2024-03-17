// See https://aka.ms/new-console-template for more information


using ConsoleApp1;

// Console.WriteLine(Namaes.nombre);




Console.WriteLine("Ingresa un numero porfavor!");
int posicion = Convert.ToInt32(Console.ReadLine());

int vidaJugador = 100;

bool a = true;
do
{
    switch (posicion)
    {
        case 1:
            Console.WriteLine("=================");
            Console.WriteLine("Posicion " + posicion);
            Console.WriteLine("Tienes " + vidaJugador + " Vida");
            Goblin goblin = new();


            Console.WriteLine("Ha spawneado un goblin !!");
            
            int daño = goblin.Ataque();
            Console.WriteLine("Te hicieron " + daño + " de daño");
            vidaJugador -= daño;
            Console.WriteLine("Tienes " + vidaJugador + " de vida");
            Console.WriteLine("=================");
            posicion = Convert.ToInt32(Console.ReadLine());
            break;

        default:
            Console.WriteLine("Posicion invalida");
            a = false;
            break;

    }
} while (a);