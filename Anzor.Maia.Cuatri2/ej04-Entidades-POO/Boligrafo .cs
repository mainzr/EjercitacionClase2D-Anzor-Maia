using System;

namespace ej04_Entidades_POO
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaTotal = this.tinta += tinta;

            if (tintaTotal >= 0 && tintaTotal <= cantidadTintaMaxima)
            {
                this.tinta = tintaTotal;
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            bool ok = false;

            Console.ForegroundColor = this.color;

            if (gasto > this.tinta)
            {
                SetTinta((short)(-1 * this.tinta));

                for (int i = 0; i < this.tinta; i++)
                {
                    dibujo += "*";
                }
                ok = true;
            }
            else if (gasto <= this.tinta)
            {
                SetTinta((short)(-1 * gasto));

                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
                ok = true;
            }
            else
            {
                dibujo += "";
            }

            return ok;

        }


    }
}
