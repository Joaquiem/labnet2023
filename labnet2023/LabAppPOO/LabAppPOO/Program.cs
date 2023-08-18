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
            EmpresaTransporte Empresa = new EmpresaTransporte();

            Empresa.AgreagarVehiculos();
            Empresa.AcelerarVeiculoPorPatente();
            Empresa.MostrarDatos();
            Empresa.DetenerVehiculoPorPatente();
            Empresa.MostrarDatos();

            Console.ReadLine();


        }
    }
}
