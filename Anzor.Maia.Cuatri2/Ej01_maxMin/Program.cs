using System;

namespace Ej01_maxMin
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeros = 0;
            int flag = 0;
            int flagMayor = 0;
            float promedio = 0;
            int acumulador = 0;

            int max = 0;
            int min = 0;

            //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese los numeros:");
                numeros = int.Parse(Console.ReadLine());

                acumulador += numeros;

                if(flag == 0 || min > numeros)
                {
                    min = numeros;
                    flag = 1;
                }

                if(flagMayor == 0 || max < numeros)
                {
                    max = numeros;
                    flagMayor = 1;
                }

            }
            promedio = acumulador / 5;


            Console.WriteLine($"Maximo: {max} - minimo: {min} - promedio: {promedio}");

        }
    }
}
