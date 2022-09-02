using System;

namespace ej01_Entidades_Encapsulamiento
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Numero
        {
            get { return this.numero; }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1.Numero == c2.Numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
