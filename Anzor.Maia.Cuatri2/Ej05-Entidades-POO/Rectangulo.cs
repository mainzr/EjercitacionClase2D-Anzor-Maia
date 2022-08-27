using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05_Entidades_POO
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());

        }
        public float GetPerimetro()
        {
            //((base + altura) * 2)
            float baseResultado;
            baseResultado = this.vertice4.GetX() - this.vertice3.GetX();

            float alturaResultado;
            alturaResultado = this.vertice4.GetY() - this.vertice1.GetY();

            this.perimetro = Math.Abs((baseResultado + alturaResultado) * 2);

            return this.perimetro;
        }

        public float GetArea()
        {
            //area base* altura
            //punto x v4 - punto x v3

            float baseResultado;
            baseResultado = this.vertice4.GetX() - this.vertice3.GetX();

            float alturaResultado;
            alturaResultado = this.vertice4.GetY() - this.vertice1.GetY();

            this.area = Math.Abs(baseResultado) * Math.Abs(alturaResultado);

            return this.area;
        }
    }


}
