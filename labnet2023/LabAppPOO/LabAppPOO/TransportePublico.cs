using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LabAppPOO
{
    public abstract class TransportePublico
    {
        public int Pasajeros { get; set; }
        public int Velocidad { get; set; }
        public string Patente { get; private set; }

        protected static int _velocidadMaxima = 100;
        protected static int _velocidadMinima = 0;
        protected static int _velocidadInicial = 0;
        protected static int _minPasajeros = 0;

        public TransportePublico()
        {
            Velocidad = _velocidadInicial;
            AgregarPatente();
        }

        private void AgregarPatente()
        {
            
            Console.WriteLine($"Ingrese la patente del vehiculo");
            Patente = Console.ReadLine();
        }

        public abstract void AgregarPasajeros();

        public abstract void MostrarDatos();

        public void Acelerar()
        {

            string input;
            do
            {
                try
                {
                    Console.WriteLine($"Ingrese la velocidad a la que quiere acelerar");
                    input = Console.ReadLine();
                    Velocidad = int.Parse(input);
                    if (Velocidad > _velocidadMaxima || Velocidad <= _velocidadMinima)
                    {
                        Console.WriteLine("La velocidad ingresada esta fuera de los parametros permitidos, ingrese una dentro entre 100 y 1");
                    }
                }
                catch (Exception e)
                { Console.WriteLine(e.Message); }
            } while (Velocidad > _velocidadMaxima || Velocidad <= _velocidadMinima);


        }

        public void Detener()
        {
            Velocidad = _velocidadMinima;
        }



    }
}
