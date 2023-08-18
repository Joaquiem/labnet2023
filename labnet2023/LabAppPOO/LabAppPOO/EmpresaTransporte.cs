using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LabAppPOO
{
    internal class EmpresaTransporte
    {
        private const int _MaxFlota = 2;
        public List<TransportePublico> flota { get; set; }
        public EmpresaTransporte()
        {
            flota = new List<TransportePublico>();
        }


        public void AgreagarVehiculos()
        {
            int mediaFlota = _MaxFlota / 2;
            TransportePublico tp;

            Console.WriteLine($"Vamos a cargar {_MaxFlota} vehiculos, que son parte de la flota de la empresa, van a ser {mediaFlota} taxis y despues {mediaFlota} omnibus : ");
            for (int i = 0; i < mediaFlota; i++)
            {
                Console.WriteLine($"Vamos a cargar los datos del taxi nro {i + 1}:");
                tp = _CrearTaxi();
                flota.Add(tp);
                Console.WriteLine("vehiculo agregado a la flota");

            }
            for (int i = 0; i < mediaFlota; i++)
            {
                Console.WriteLine($"Vamos a cargar los datos del omnibus nro {i + 1}:");
                tp = _CrearOmnibus();
                flota.Add(tp);
            }

        }

        private Taxi _CrearTaxi()
        {
            Taxi vehiculo = new Taxi();
            return vehiculo;

        }

        private Omnibus _CrearOmnibus()
        {
            Omnibus vehiculo = new Omnibus();
            return vehiculo;
        }

        public void AcelerarVeiculoPorPatente()
        {
            TransportePublico tp;
            string input;

            Console.WriteLine("Escriba la patente del auto que quiere acelerar:");
            
            do
            {
                input = Console.ReadLine();
                tp = _BuscarVehiculoPorPatente(input);
                if (tp == null)
                {
                    Console.WriteLine("La patente no fue encontrada, escibra una que corresponda a la flota");
                }
            } while (tp == null);
            tp.Acelerar();

        }

        public void DetenerVehiculoPorPatente()
        {
            TransportePublico tp;
            string input;

            Console.WriteLine("Escriba la patente del auto que quiere detener:");

            do
            {
                input = Console.ReadLine();
                tp = _BuscarVehiculoPorPatente(input);
                if (tp == null)
                {
                    Console.WriteLine("La patente no fue encontrada, escibra una que corresponda a la flota");
                }
            } while (tp == null);
            tp.Detener();

        }

        private TransportePublico _BuscarVehiculoPorPatente(string input)
        { 
            return flota.Find(tp => tp.Patente.Equals(input));
        }

        public void MostrarDatos()
        {

            foreach (var v in flota)
            {
                v.MostrarDatos();
            }
        }
    }
}
