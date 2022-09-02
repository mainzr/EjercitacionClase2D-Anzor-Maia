using System;

namespace Ej01_Entidades_Sobrecarga
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) //this llama al constructor anterior, se le pasa por parammetro la variable que necesite
        {

        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            long resultado = a + b;

            return resultado;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            string cadenaResultado = a + b;

            return cadenaResultado;
        }

        public static explicit operator int(Sumador objeto) //permite realizar el casteo de lo que quiera sin que de error
                                                            //devuelve lo que le digas que devuelva
        {
            return objeto.cantidadSumas;
        }

        public static long operator +(Sumador objeto1, Sumador objeto2)
        {
            long resultadoSumas = objeto1.cantidadSumas + objeto2.cantidadSumas;

            return resultadoSumas;
        }

        public static bool operator |(Sumador operador1, Sumador operador2)
        {
            bool resultado;
            if (operador1.cantidadSumas == operador2.cantidadSumas)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
