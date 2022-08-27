using System;
using System.Text;

namespace Ej05_AprendeteLasTablas
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;

            Console.WriteLine("ingrese un numero: ");
            numeroIngresado = Console.ReadLine();

            if(int.TryParse(numeroIngresado, out _) && !string.IsNullOrEmpty(numeroIngresado))
            {
                Console.WriteLine($"{Multiplicar(int.Parse(numeroIngresado))}");
            }
            else
            {
                Console.WriteLine("Error al ingresar numero...");
            }
        }

        public static string Multiplicar(int numero)
        {
            StringBuilder sb = new StringBuilder();
            int resultado;

            sb.AppendLine($"Tabla de multiplicar del número {numero}:");

            for (int i = 1; i < 10; i++)
            {
                resultado = numero * i;
                sb.AppendLine($"{numero} x {i} = {resultado}");
            }

            return sb.ToString();
        }
    }
}
