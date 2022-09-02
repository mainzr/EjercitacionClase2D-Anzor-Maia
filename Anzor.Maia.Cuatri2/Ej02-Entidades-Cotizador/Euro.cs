using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02_Entidades_Cotizador
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 1;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        //Instancia objeto euro, crea un objeto euro para castear lo pasado por paramtro
        public static implicit operator Euro(double e)
        {
            Euro unEuro = new Euro(e);
            return unEuro;
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar unDolar = new Dolar(e.cantidad * Dolar.GetCotizacion());

            return unDolar;
        }


        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }


        //SOBRECARGA DE OPERADORES == Y !=
        public static bool operator ==(Euro e, Dolar d)
        {
            bool resultado = false;

            if (((Dolar)e) == d)
            {
                resultado = true;
            }

            return resultado;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool resultado = false;

            if (((Dolar)e) == ((Dolar)p))
            {
                resultado = true;
            }
            return resultado;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }


        public static bool operator ==(Euro e1, Euro e2)
        {
            bool resultado = false;

            if (e1.GetCantidad() == e2.GetCantidad())
            {
                resultado = true;
            }

            return resultado;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e.cantidad + ((Euro)d).GetCantidad();
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e.cantidad + ((Euro)p).GetCantidad();
        }
    }
}
