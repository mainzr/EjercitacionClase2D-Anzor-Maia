using System;
using System.Collections.Generic;

namespace Ej02_Entidades_Encapsulamiento
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public int CantidadPaginas
        {
            get { return this.paginas.Count; }
        }
        public string this[int i]
        {
            // leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango correcto, sino retornará un string vacío.
            get
            {
                if(i > 0 || i < this.paginas.Count)
                {
                    return this.paginas[i ];
                }
                else
                {
                    return string.Empty;
                }
            }

            //si la página existe (existe ese índice) le asignará el texto.
            //Si no existe (si el índice es superior al máximo existente), agregará una nueva página.
            set
            {
                if(i >= 0 && i < this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else if(i == this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else
                {
                    Console.WriteLine("error indice");
                }
               
            }


        }

        
    }
}
