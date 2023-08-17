using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAppPOO
{
    public abstract class TransportePublico
    {
        public int Pasajeros { get; set; }
        protected static int MinPasajeros = 0;  

        public TransportePublico ()
        {

        }

    public abstract void AgregarPasajeros();

    public abstract string MostrarDatos();



    }
}
