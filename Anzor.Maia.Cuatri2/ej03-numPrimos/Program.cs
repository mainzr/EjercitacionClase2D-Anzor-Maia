using System;

namespace ej03_numPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.*/
            string respuestaIngresar;
            string numeroIngresado;
            bool esNumero;
            do
            {

                Console.WriteLine("Ingrese un  numero: ");
                numeroIngresado = Console.ReadLine();
                esNumero = int.TryParse(numeroIngresado, out _);
              
                if(esNumero)
                {
                    Console.Write($"Numeros  primos: ");
                    for (int i = 2; i < int.Parse(numeroIngresado); i++)
                    {
                        if ((int.Parse(numeroIngresado) % i) != 0)
                        {
                            Console.Write($"{i};");
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"'{numeroIngresado}' no es un numero! Error!\n");
                }
                

                Console.WriteLine("\n\nDesea ingresar otro numero? (si/no)");
                respuestaIngresar = Console.ReadLine();

            } while (respuestaIngresar != "no");

            ////////////////////
            if (respuestaIngresar == "no")
            {
                Environment.Exit(0);
            }




        }
    }
}
