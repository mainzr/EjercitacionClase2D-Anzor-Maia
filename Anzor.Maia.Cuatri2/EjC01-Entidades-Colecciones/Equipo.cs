using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjC01_Entidades_Colecciones
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

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            //agregará jugadores a la lista siempre y
            //cuando no exista aún en el equipo
            //y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores.
            bool retorno = false;

            foreach (Jugador item in e.jugadores)
            {
                if(item != j && e.jugadores.Count > e.cantidadJugadores)
                {
                    e.jugadores.Add(j);
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
