using System;
using System.Text;

namespace Ej01_Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            
        }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public float GetPromedioGoles
        {
            get { return (float)this.totalGoles / this.partidosJugados ; }

        }
        


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"PARTIDOS JUGADOS: {this.partidosJugados}");
            sb.AppendLine($"PROMEDIO GOLES: {this.promedioGoles}");
            sb.AppendLine($"TOTAL GOLES: {this.totalGoles}");
            sb.AppendLine($"PROMEDIO GOLES: {this.GetPromedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
    
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
