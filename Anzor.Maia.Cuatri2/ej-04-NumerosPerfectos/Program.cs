using System;

namespace ej_04_NumerosPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            string numeroIngresado;
            bool esNumero;
            int sumaDivisores = 0;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresado = Console.ReadLine();

            esNumero = int.TryParse(numeroIngresado, out _);

 
            if(!string.IsNullOrEmpty(numeroIngresado) || esNumero || !string.IsNullOrWhiteSpace(numeroIngresado))
            {
                for (int i = 1; i < int.Parse(numeroIngresado); i++)
                {
                    if ((int.Parse(numeroIngresado) % i) == 0)
                    {
                        Console.WriteLine($"Los divisores de {numeroIngresado} son: {i}");

                        sumaDivisores += i;

                        if (sumaDivisores == int.Parse(numeroIngresado))
                        {
                            Console.WriteLine($"la suma de los divisores es: {sumaDivisores}");
                            break;

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"\nERROR AL INGRESAR NUMERO.");
            }

           

           
        }
    }
}
