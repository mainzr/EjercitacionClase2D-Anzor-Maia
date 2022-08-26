using System;
using Entidades_Ej01;

namespace Ej01_ViajarEsUnPlacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4, 4, 10, Colores.Azul, 2);
            Console.WriteLine($"AUTO\n cantidad de ruedas: {auto.cantidadRuedas}\n cantidad de puertas: {auto.cantidadPuertas}\n cantidad de Marchas: {auto.cantidadMarchas}\n color: {auto.color}, \n cantidad pasajeros: {auto.cantidadPasajeros}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            Moto motito = new Moto(10, 2, 0, Colores.Blanco);
            Console.WriteLine($"MOTO\n cilindrada: {motito.cilindrada},\ncantidad de ruedas: {motito.cantidadRuedas},\n cantidad puertas: {motito.cantidadPuertas},\n color: {motito.color}");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            Camion camion = new Camion(2, 2, 12, Colores.Gris, 20);
            Console.WriteLine($"CAMION\n cantidad ruedas: {camion.cantidadRuedas},\n cantidad puertas {camion.cantidadPuertas},\n cantidad marchas: {camion.cantidadMarchas},\n color: {camion.color},\n peso carga: {camion.PesoCarga}");

        }
    }
}
