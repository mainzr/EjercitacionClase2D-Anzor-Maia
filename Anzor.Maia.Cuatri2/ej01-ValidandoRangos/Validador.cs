using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01_ValidandoRangos
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            //Pedir al usuario que ingrese 10 números enteros.
            //Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

            if (valor < min || valor > max)
            {
                return false;
            }
            return true;
        }
    }
}
