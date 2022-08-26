using System;

namespace ej06_ReciboDeSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de inicio: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero final: ");
            int final = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n Lista de años bisiestoss entre {inicio} y {final} son : ");

            for (int i = inicio; i < final; i++)
            {
                if (((i % 4) == 0) || ((i % 100) == 0 && (i % 400) == 0))
                {
                    Console.WriteLine($" {i}");
                }
            }

        }
    }
}
