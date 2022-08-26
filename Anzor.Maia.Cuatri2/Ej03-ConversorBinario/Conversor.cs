using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03_ConversorBinario
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            //convierte un número entero del sistema decimal al sistema binario.
            string numeroBinario = null;
            int resultado;
            string numeroDecimal = Convert.ToString(numeroEntero);

            resultado = (numeroEntero / 2);

            while (numeroEntero != 0)
            {
                if ((numeroEntero % 2) == 0)
                {
                    numeroBinario = 0 + numeroBinario;
                }
                else if ((numeroEntero % 2) == 1)
                {
                    numeroBinario = 1 + numeroBinario;
                }
                numeroEntero = numeroEntero / 2;
            }


            return numeroBinario;
        }


        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numero = string.Empty;
            int elevacion = 0;
            int tamNum = numero.Length;
            numero += numeroEntero;

            foreach (char caracteresNum in numero)
            {
                tamNum--;
                if (caracteresNum != '0')
                {
                    elevacion += (int)Math.Pow(2, tamNum);

                }
            }

            return elevacion;
        }

    }
}
