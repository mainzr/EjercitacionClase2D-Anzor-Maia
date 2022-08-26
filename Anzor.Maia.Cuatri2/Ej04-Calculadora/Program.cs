using System;

namespace Ej04_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char seguir;
            int operadorUno;
            int operadorDos;
            char operacion;
            int i;
            bool esNumero;

            do
            {
                Console.WriteLine("Ingrese primer operador: ");
                string l = Console.ReadLine();
                esNumero = int.TryParse(l, out operadorUno);

                while (esNumero == false)
                {
                    Console.WriteLine($"Error! no es numero...Reingreselo nuevamnte: ");
                    operadorUno = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese operdor dos: ");
                operadorDos = int.Parse(Console.ReadLine());
                if (!int.TryParse(Convert.ToString(operadorUno), out _))
                {
                    Console.WriteLine($"Error! '{operadorDos}' no es numero...Reingreselo nuevamnte: ");
                    operadorDos = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese operacion: (+, -, *, /)");
                operacion = char.Parse(Console.ReadLine());

                if (operacion != '+' && operacion != '/' && operacion != '-' && operacion != '*' )
                {
                    Console.WriteLine("Error! operacion incorrecta..reingrese operacion (+, -, *, /): ");
                    operacion = char.Parse(Console.ReadLine());
                }

                Console.WriteLine($"resutlado: {Calculadora.Calcular(operadorUno, operadorDos, operacion)}");

                Console.WriteLine("desea realizar otra operacion? s/n");
                seguir = char.Parse(Console.ReadLine());

            } while (seguir == 's');
           
        }
    }
}
