using System;
using System.Text;

namespace Ej03_EntidadesPOO
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;

        }

        public double CalcularNotaFinal()
        {
            double finalRandom = Estudiante.random.Next(6, 10);
            double retorno;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                retorno = finalRandom;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"APELLIDO: {this.apellido}");
            sb.AppendLine($"LEGAJO: {this.legajo}");
            sb.AppendLine($"NOTA PRIMER PARCIAL: {this.notaPrimerParcial}");
            sb.AppendLine($"NOTA SEGUNDO PARCIAL: {this.notaSegundoParcial}");
            sb.AppendLine($"PROMEDIO: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"NOTA FINAL: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine($"Alumno desaprobado");
            }
            sb.AppendLine("-------------------------------------");


            return sb.ToString();
        }
    }
}
