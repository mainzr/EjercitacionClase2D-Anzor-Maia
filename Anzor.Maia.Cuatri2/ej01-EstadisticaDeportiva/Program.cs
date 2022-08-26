using System;
using Ej01_Entidades;

namespace ej01_EstadisticaDeportiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador unJugador = new Jugador(2344, "Maia", 20, 5);
            Jugador unJugador2 = new Jugador(2344, "Lucas", 2, 10);
            Jugador unJugador3 = new Jugador(6745, "Lean", 10, 12);
            Jugador unJugador4 = new Jugador(2378, "Bian", 8, 3);
            Jugador unJugador5 = new Jugador(2321, "hola", 8, 3);


            DirectorTecnico unDirector = new DirectorTecnico("Mario", new DateTime(2001, 04, 10));


            Equipo unEquipo = new Equipo(3, "Soles");

            if (unEquipo + unJugador)
            {
                Console.WriteLine("Jugador 1 agregado con exito.");
            }

            if (unEquipo + unJugador2)
            {
                Console.WriteLine("Jugador 2 agregado con exito.");
            }
            if (unEquipo + unJugador3)
            {
                Console.WriteLine("Jugador 3 agregado con exito.");
            }
            if (unEquipo + unJugador4)
            {
                Console.WriteLine("Jugador 4 agregado con exito.");
            }


            Console.WriteLine(unJugador.MostrarDatos());
            Console.WriteLine(unJugador2.MostrarDatos());
            Console.WriteLine(unJugador3.MostrarDatos());
            Console.WriteLine(unJugador4.MostrarDatos());


        }
    }
}
