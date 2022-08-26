using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04_Calculadora
{
    public class Calculadora
    {
        public static int Calcular(int operandoUno, int operandoDos, char operacion)
        {
            int resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = operandoUno + operandoDos;
                    break;
                case '-':
                    resultado = operandoUno - operandoDos;
                    break;
                case '*':
                    resultado = operandoUno * operandoDos;
                    break;
                case '/':
                    if (Validar(operandoDos))
                    {
                        resultado = operandoUno / operandoDos;
                    }
                    else
                    {
                        Console.WriteLine($"Error no se puede dividir por 0...");
                    }
                    break;
                default:
                    Console.WriteLine("Error al seleccionar tipo de operacion");
                    break;
            }

            return resultado;
        }

        private static bool Validar(int operandoDos)
        {
            return (operandoDos != 0);
        }
    }
}
