using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02_Entidades_Cotizador
{
    public class Pesos
    {
        private double cantidad;
        private static double ctzRespectoDolar;

        static Pesos()
        {
            Pesos.ctzRespectoDolar = 138.6f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.ctzRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Pesos.ctzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Pesos(double d)
        {
            Pesos unPeso = new Pesos(d);

            return unPeso;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar unDolar = new Dolar(p.cantidad / Pesos.GetCotizacion());

            return unDolar;
        }
        //multiplo el valor del dolar y el valor de pesos para sacar el valor de euros en pesos
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p); //CASTEO PESO A DOLAR - DOOLAR A EURO
                                     //casteo genera un nuevo objeto
        }


        //SOBRECARGA DE OPERADORES == Y !=
        public static bool operator ==(Pesos p, Dolar d)
        {
            bool resultado = false;

            if (((Dolar)p) == d)
            {
                resultado = true;
            }

            return resultado;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }


        public static bool operator ==(Pesos p, Euro e)
        {
            bool resultado = false;

            if (p == ((Pesos)e))
            {
                resultado = true;
            }

            return resultado;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool resultado = false;

            if (p1.GetCantidad() == p2.GetCantidad())
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.cantidad + ((Pesos)e).GetCantidad();
        }


        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.cantidad + ((Pesos)d).GetCantidad();
        }
    }
}
