using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ej01_Entidades_Encapsulamiento
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) 
        {
            this.puesto = puesto;
        }

        static int NumeroActual
        {
            get { return PuestoAtencion.numeroActual++; }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000); 
            if(cli)
        }


    }
}
