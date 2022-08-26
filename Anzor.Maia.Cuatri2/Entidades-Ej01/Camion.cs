using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ej01
{
    public class Camion : VehiculoTerrestre
    {
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores colores, int pesoCarga) : base( cantidadRuedas,  cantidadPuertas, colores)
        {
            this.pesoCarga = pesoCarga;
        }
    }
}
