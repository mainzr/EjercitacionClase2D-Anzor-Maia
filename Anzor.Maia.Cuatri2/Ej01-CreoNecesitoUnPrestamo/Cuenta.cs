using System;
using System.Text;

namespace Ej01_CreoNecesitoUnPrestamo
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta( decimal cantidad, string titular)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get { return this.titular; }
        }

        public decimal Cantidad
        {
            get { return this.cantidad; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"TITULAR: {this.Titular}");
            sb.AppendLine($"MONTO EN CUENTA: {this.Cantidad}");

            return sb.ToString();
        }

        public bool Ingresar(decimal monto)
        {
            //ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            bool retorno = true;

            if(monto > 0)
            {
                this.cantidad += monto;
                
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        //retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        public bool Retirar(decimal cantidadRetirar)
        {
            bool retorno = false ;
            if(cantidadRetirar > 0)
            {
                this.cantidad -= cantidadRetirar;
                retorno = true;
            }

            return retorno;
        }
    }
}
