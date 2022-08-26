using System;

namespace Entidades_Ej01
{
    public class Automovil : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores colores, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, colores)
        {
            this.cantidadPuertas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }


    }
}
