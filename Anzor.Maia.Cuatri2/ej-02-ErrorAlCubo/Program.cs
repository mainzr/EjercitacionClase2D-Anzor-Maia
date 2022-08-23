using System;

namespace ej_02_ErrorAlCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!"

            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("ingrese el numero:");
            numero = int.Parse(Console.ReadLine());

            while (numero < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }


            cuadrado = Math.Pow(numero, numero);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine($"Numero al cubo: {cubo} - numero al cuadrado: {cuadrado}");
        }
    }
}
