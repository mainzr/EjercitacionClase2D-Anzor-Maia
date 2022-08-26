using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ej01
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cilindrada, short cantidadRuedas,
            short cantidadPuertas, Colores color)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
