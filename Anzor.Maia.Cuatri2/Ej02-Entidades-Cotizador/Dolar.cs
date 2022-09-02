using System;

namespace Ej02_Entidades_Cotizador
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) 
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }
        public static implicit operator Dolar(double d)
        {
            Dolar unDolar = new Dolar(d); //Instancia objeto dolar, crea un objeto dolar para castear lo pasado por paramtro

            return unDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro unEuro = new Euro(d.cantidad * Euro.GetCotizacion()); //cantidad de dolares por la cotizacion de euro = devuelve el valor de doalres ne euros

            return unEuro;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos unPeso = new Pesos(d.cantidad * Pesos.GetCotizacion());

            return unPeso;
        }

        //SOBRECARGA DE OPERADOR == Y !=

        public static bool operator ==(Dolar d, Euro e)
        {
            bool resultado = false;

            if (d == ((Dolar)e)) //se castea e euro a dolar
                                 //se reutiliza el casteo para comparar cantidades
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool operator !=(Dolar d, Euro e)
        {

            return !(d == e); //usa la sobrecarga del operador ==
        }


        public static bool operator ==(Dolar d, Pesos p)
        {
            bool resultado = false;

            if (d == ((Dolar)p))
            {
                resultado = true;
            }
            return resultado;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {

            return !(d == p);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool resultado = false;
            if (d1.GetCantidad() == d2.GetCantidad()) //no se castea porque la moneda ya es dolar
            {
                resultado = true;
            }

            return resultado;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        //SOBRECARGA DE OPERADORES 

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar resultado = new Dolar(d.cantidad);

            resultado = d.cantidad - ((Dolar)e).GetCantidad();

            return resultado;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d.cantidad + ((Dolar)e).GetCantidad();
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d.cantidad + ((Dolar)p).GetCantidad();
        }
    }
}
