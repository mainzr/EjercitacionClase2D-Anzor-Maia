using System;
using System.Text;

namespace EjC01_Entidades_Colecciones
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {

        }

        public float GetPromedioGoles()
        {
            promedioGoles = (float)totalGoles / (float)partidosJugados;

            return promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"PARTIDO JUGADOS: {this.partidosJugados}");
            sb.AppendLine($"PROMEDIO GOLES: {this.GetPromedioGoles()}");
            sb.AppendLine($"TOTAL GOLES: {this.totalGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.dni == j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
