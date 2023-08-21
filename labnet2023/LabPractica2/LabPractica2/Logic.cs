using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabPractica2
{
    public class Logic : Exception
    {

        public Logic() { }
     
        public void ThrowException() { 
            throw new Exception();
        }
        public void ExcepcionPersonalizada()
        {
            throw new Exception("excepcion personalizada");
        }
    }
}
