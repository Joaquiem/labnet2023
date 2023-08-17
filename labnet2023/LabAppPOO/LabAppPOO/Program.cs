using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpresaTransporte Empresa= new EmpresaTransporte();

            TransportePublico Taxi1 = new Taxi();
            TransportePublico Taxi2 = new Taxi();
            TransportePublico Taxi3 = new Taxi();
            TransportePublico Taxi4 = new Taxi();
            TransportePublico Taxi5 = new Taxi();

            TransportePublico Omnibus1 = new Omnibus();
            TransportePublico Omnibus2 = new Omnibus();
            TransportePublico Omnibus3 = new Omnibus();
            TransportePublico Omnibus4 = new Omnibus();
            TransportePublico Omnibus5 = new Omnibus();

            Empresa.AgreagarVehiculos(Taxi1);
            Empresa.AgreagarVehiculos(Taxi2);
            Empresa.AgreagarVehiculos(Taxi3);
            Empresa.AgreagarVehiculos(Taxi4);
            Empresa.AgreagarVehiculos(Taxi5);

            Empresa.AgreagarVehiculos(Omnibus1);
            Empresa.AgreagarVehiculos(Omnibus2);
            Empresa.AgreagarVehiculos(Omnibus3);
            Empresa.AgreagarVehiculos(Omnibus4);
            Empresa.AgreagarVehiculos(Omnibus5);

            Taxi1.AgregarPasajeros();
            Taxi2.AgregarPasajeros();
            Taxi3.AgregarPasajeros();
            Taxi4.AgregarPasajeros();
            Taxi5.AgregarPasajeros();

            Omnibus1.AgregarPasajeros();
            Omnibus2.AgregarPasajeros();
            Omnibus3.AgregarPasajeros();
            Omnibus4.AgregarPasajeros();
            Omnibus5.AgregarPasajeros();

            Empresa.MostrarDatos();
            

            Console.ReadLine();


        }
    }
}
