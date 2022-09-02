using System;
using Ej01_Entidades_Sobrecarga;

namespace Ej01_Sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador objeto = new Sumador();
            Sumador objeto2 = new Sumador();

            Console.WriteLine(objeto.Sumar(2, 5));
            Console.WriteLine(objeto.Sumar("2", "1"));

            Console.WriteLine((int)objeto);

            Console.WriteLine(objeto + objeto2); //se pueden sumar objetos por la sobrecarga del operador +
            Console.WriteLine(objeto | objeto2);
        }
    }
}
