using System;
using ej01_ValidandoRangos;

namespace ej01_ValidandoRangos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            int flagNumeroMin = 0;
            int flagNumeroMax = 0;
            int acumualador = 0;
            int numeroMin = 0;
            int numeroMax = 0;
            float promedioIngresos = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese los numeros: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                while (Validador.Validar(numeroIngresado, -100, 100) == false)
                {
                    Console.WriteLine($"\nError! Numero fuera de rango (-100 / 100)");

                    Console.WriteLine($"\nReingrese numero: ");
                    numeroIngresado = int.Parse(Console.ReadLine());

                }

                if (!string.IsNullOrEmpty(Convert.ToString(numeroIngresado)))
                {
                    if (int.TryParse(Convert.ToString(numeroIngresado), out _))
                    {
                        acumualador += numeroIngresado;

                        if (flagNumeroMin == 0 || numeroIngresado < numeroMin)
                        {
                            numeroMin = numeroIngresado;
                            flagNumeroMin = 1;
                        }

                        if (flagNumeroMax == 0 || numeroIngresado > numeroMax)
                        {
                            numeroMax = numeroIngresado;
                            flagNumeroMax = 1;
                        }

                        promedioIngresos = ((float)acumualador) / 10;
                    }
                }
                else
                {
                    Console.WriteLine($"\nError al ingresar numeros");
                }


            }

            Console.WriteLine($"Numero dentro del rango aceptado.\n");
            Console.WriteLine($"Promedio: {promedioIngresos}");
            Console.WriteLine($"Numero minimo: {numeroMin} / numero max: {numeroMax}");

        }


    }
}
