using System;
using System.Text;

namespace Ej02_Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int resultadoEdad;

            resultadoEdad = fechaActual.Year - this.FechaDeNacimiento.Year;//resta años de fecha actual a lo que se pasaron por paramtro

            if (this.FechaDeNacimiento.Month > fechaActual.Month)
            {
                resultadoEdad--;
            }

            return resultadoEdad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {this.Nombre}");
            sb.AppendLine($"FECHA NACIMIENTO:{this.fechaDeNacimiento:dd/MM/yyyy}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"EDAD: {this.CalcularEdad()}");

            return sb.ToString();
        }

        public string EsMayorDeEdad(int edad)
        {
            string retorno = string.Empty;

            if(CalcularEdad() > 18)
            {
                retorno = "Es mayor de edad";
            }
            else
            {
                retorno = "Es menor";
            }

            return retorno;
        }
    }

}
