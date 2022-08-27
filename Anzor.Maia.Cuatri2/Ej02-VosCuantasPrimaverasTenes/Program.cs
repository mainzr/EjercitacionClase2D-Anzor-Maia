using System;
using Ej02_Entidades;

namespace Ej02_VosCuantasPrimaverasTenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona datos = new Persona("jose", new DateTime(2000, 03, 10), 34982084);
            Persona datos2 = new Persona("Maia", new DateTime(2001, 12, 03), 96784102);
            Persona datos3 = new Persona("Lean", new DateTime(1991, 12, 17), 48450261);

            Console.WriteLine(datos.Mostrar());
            Console.WriteLine(datos2.Mostrar());
            Console.WriteLine(datos3.Mostrar());
        }
    }
}
