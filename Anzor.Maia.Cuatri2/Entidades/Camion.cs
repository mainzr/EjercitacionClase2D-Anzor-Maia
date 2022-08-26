using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Camion : Automovil
    {
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base( cantidadRuedas, cantidadPuertas, color, cantidadMarchas,pesoCarga)
        {

        }
    }
}
