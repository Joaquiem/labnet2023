using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LabAppPOO
{
    internal class Taxi : TransportePublico
    {

        private readonly int _maxPasajeros = 4;

        public Taxi()
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
                { Console.WriteLine(e.Message); }
            } while (Pasajeros > _maxPasajeros || Pasajeros <= _minPasajeros);


        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"El taxi patente {this.Patente} tiene {Pasajeros} pasajeros y su velocidad es: {Velocidad}");
        }


    }
}

