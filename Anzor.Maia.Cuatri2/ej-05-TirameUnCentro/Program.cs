using System;

namespace ej_05_TirameUnCentro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = 1;
            int acumuladorUno = 0;
            int acumuladorDos = 0;

            Console.WriteLine("Ingrese el numero hasta el cual desee saber: ");
            int numElegido = int.Parse(Console.ReadLine());

            for (int i = 1; i < numElegido; i++)
            {
                acumuladorUno = 0;

                for (int j = 1; j < numeros; j++) //numeros = se mueve un casillero hasta el final
                {
                    acumuladorUno += j;
                }

                acumuladorDos = 0;

                for (int y = numeros + 1; y <= numElegido; y++)
                {
                    if ((acumuladorDos == acumuladorUno) || (acumuladorDos > acumuladorUno))
                    {
                        break;

                    }
                    else
                    {
                        acumuladorDos += y;
                    }

                }

                if (acumuladorDos == acumuladorUno)
                {
                    Console.WriteLine("los centros hasta {0} : {1}", numElegido, numeros);

                }
                numeros++;

            }


        }
    }
}
