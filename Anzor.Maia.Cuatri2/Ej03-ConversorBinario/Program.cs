using System;

namespace Ej03_ConversorBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.ConvertirDecimalABinario(123));

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(1000));
        }
    }
}
