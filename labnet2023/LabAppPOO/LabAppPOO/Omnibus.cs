using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppPOO
{
    internal class Omnibus : TransportePublico
    {
        private static int _maxPasajeros = 24;

        public Omnibus()
        {
            AgregarPasajeros();
        }

        public override void AgregarPasajeros()
        {
            string input;
            do
            {
                try
                {
                    Console.WriteLine($"Ingrese la cantidad de pasajeros, no debe ser mayor a {_maxPasajeros} ni menor o igual a {_minPasajeros}.");
                    input = Console.ReadLine();
                    Pasajeros = int.Parse(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (Pasajeros > _maxPasajeros || Pasajeros <= _minPasajeros);

        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"El Omnibus patente {Patente.ToString()} tiene {Pasajeros} pasajeros y su velocidad es: {Velocidad}");
        }


    }
}
