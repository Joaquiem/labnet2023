using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppPOO
{
    internal class Omnibus : TransportePublico
    {
        private static int MaxPasajeros = 24;

        public Omnibus() 
        {    
        }
        public override void AgregarPasajeros()
        {
            string input;
            do
            {
                try
                {
                    Console.WriteLine($"Ingrese la cantidad de pasajeros, no debe ser mayor a {MaxPasajeros} ni menor o igual a {MinPasajeros}.");
                    input = Console.ReadLine();
                    Pasajeros = int.Parse(input);
                }
                catch {
                    Console.WriteLine("Tipo de dato invalido");
                }
            } while (Pasajeros > MaxPasajeros || Pasajeros <= MinPasajeros);

        }

        public override string MostrarDatos()
        {
            return $"{this} tiene {Pasajeros} pasajeros";
        }
    }
}
