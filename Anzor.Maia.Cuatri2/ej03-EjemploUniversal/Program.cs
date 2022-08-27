using System;
using Ej03_EntidadesPOO;

namespace ej03_EjemploUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante persona1 = new Estudiante("Maia", "Anzor", "5210");
            Estudiante persona2 = new Estudiante("Lucas", "Allende", "8520");
            Estudiante persona3 = new Estudiante("Leandro", "Avalos", "7410");

            persona1.SetNotaPrimerParcial(1);
            persona1.SetNotaSegundoParcial(3);
            persona2.SetNotaPrimerParcial(6);
            persona2.SetNotaSegundoParcial(10);
            persona3.SetNotaPrimerParcial(8);
            persona3.SetNotaSegundoParcial(9);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
        }
    }
}
