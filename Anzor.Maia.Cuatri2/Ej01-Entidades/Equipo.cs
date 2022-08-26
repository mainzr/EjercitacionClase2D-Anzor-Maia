using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01_Entidades
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach (Jugador unJugador in e.jugadores)
            {
                if(unJugador != j && e.jugadores.Count < e.cantidadJugadores)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

    }
}
