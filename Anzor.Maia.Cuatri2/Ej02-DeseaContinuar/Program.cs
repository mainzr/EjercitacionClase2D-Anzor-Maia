using System;

namespace Ej02_DeseaContinuar
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta ;
            int numeroIngresado = 0;
            int sumaTotal = 0;
            do
            {
                Console.WriteLine($"Ingrese un numero:");
                numeroIngresado = int.Parse(Console.ReadLine());

                sumaTotal += numeroIngresado;

                Console.WriteLine($"Desea seguir ingresando numeros?: s/n");
                respuesta = Console.ReadLine();


            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"\nSuma total: {sumaTotal}");
        }
    }
}
