using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01_Entidades_Encapsulamiento
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        // retornará el próximo cliente en la cola de atención en el get.
        // El set deberá controlar que el Cliente no figure en la cola de atención, caso contrario lo agregará.
        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }
            set
            {
                _ = this + value;  // _ -> variable descartable, se usa como reemeplazo para no declarar varible al pedo, valor de '_' se pierde
                //this -> referencia al negocio por estar en clase negocio
                //se ncesita objeto Negocio + objeto Cliente
            }

        }

        //La propiedad ClientesPendientes retornará la cantidad de clientes esperando a ser atendidos.
        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }

        //El operador == retornará true si el cliente se encuentra en la colección.
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool r = false;

            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    r = true;
                    break;
                }
            }

            return r;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        //El operador + será el único capaz de agregar un Cliente a la cola de atención.
        //Sólo se agregará un Cliente si este no forma parte de la lista. Reutilizar el == de Cliente.
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if(n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        //El operador ~ generará una atención del próximo cliente en la cola,
        //utilizando la propiedad Cliente y el método Atender de PuestoAtencion.
        //Retornará true si pudo realizar la operación completa
        public static bool operator ~(Negocio n)
        {
            bool retorno = false;

            if (ej01_Entidades_Encapsulamiento.PuestoAtencion.Atender(n.Cliente) && n.clientes.Count > 0)
            {
                retorno = true;
            }

            return retorno;
        }




    }
}
