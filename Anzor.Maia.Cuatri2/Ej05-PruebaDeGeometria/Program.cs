using System;
using System.Text;
using Ej05_Entidades_POO;

namespace Ej05_PruebaDeGeometria
{
    class Program
    {
        public static string Mostrar(Rectangulo rectanguloHijo)
        {
            StringBuilder resultado = new StringBuilder();

            resultado.AppendLine($"AREA: {rectanguloHijo.GetArea()}");
            resultado.AppendLine($"PERIMETRO: {rectanguloHijo.GetPerimetro()}");

            return resultado.ToString();
        }

        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(new Punto(2, 3), new Punto(7, -1));

            Console.WriteLine(Mostrar(rectangulo));
        }
    }
}
