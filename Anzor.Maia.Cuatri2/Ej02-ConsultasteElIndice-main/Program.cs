using System;
using Ej02_Entidades_Encapsulamiento;

namespace Ej02_ConsultasteElIndice_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Jon I";
            libro[1] = "Daenerys II";
            libro[2] = "Casper II";
            libro[6] = "hola";
            libro[-31] = "Utopia II";

            for (int i = 0; i < libro.CantidadPaginas; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Tyrion III";

            for (int i = 0; i < libro.CantidadPaginas; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
