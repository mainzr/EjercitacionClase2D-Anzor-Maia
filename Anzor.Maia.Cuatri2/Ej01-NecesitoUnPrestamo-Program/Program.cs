using System;
using Ej01_CreoNecesitoUnPrestamo;

namespace Ej01_NecesitoUnPrestamo_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta dinero = new Cuenta(500, "Jose");

            Console.WriteLine("-----ingrese saldo.");
            decimal ingreso = decimal.Parse(Console.ReadLine());

            Console.WriteLine(dinero.Mostrar());

            Console.WriteLine("\n-----saldo actualizado. ");
            dinero.Ingresar(ingreso);
            Console.WriteLine(dinero.Mostrar());

            Console.WriteLine("\n\n----cantidad a retirar: ");
            decimal retirar = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n-----saldo actualizado. ");
            Console.WriteLine(dinero.Mostrar());
            dinero.Retirar(retirar);
            Console.WriteLine(dinero.Mostrar());
        }
    }
}
