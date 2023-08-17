using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabAppPOO
{
    internal class EmpresaTransporte 
    {
        public List<TransportePublico> flota { get; set; }
        public EmpresaTransporte()
        {
            flota = new List<TransportePublico>();
        }


        public void AgreagarVehiculos(TransportePublico vehiculo)
        {
            flota.Add(vehiculo);
        }

        public void MostrarDatos()
        {
            foreach (TransportePublico v in flota)
            {
                Console.WriteLine(v.MostrarDatos());
            }
        }

    }
}
