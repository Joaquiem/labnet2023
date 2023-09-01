using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;

namespace Lab.Demo.EF.UI
{
    internal class MenuCustomers : MenuBase
    {
        private IABMLogic <Customers, string> _customersLogic = new CustomersLogic();

        public override void Agregar()
        {
           Customers customer = new Customers();
           Console.WriteLine("Agregar un cliente, primero agregamos el id luego la empresa:");
           customer.CustomerID = Utilidades.LeerTexto();
           customer.CompanyName = Utilidades.LeerTexto();
           _customersLogic.Insert(customer);
            Console.ReadKey();
        }

        public override void Modificar()
        {
            Console.WriteLine("Ingrese el ID del cliente a Modificar");
            var customer = Buscar();
            Console.WriteLine("Cliente a modificar:\n" + customer);
            Console.WriteLine("Ingrese nuevo nombre del cliente o ingrese 0 para salir:");
            string str = Utilidades.LeerTexto();
            if (str != "0")
            {
                customer.CompanyName = str;
                _customersLogic.Update(customer);
                Console.WriteLine($"Cliente {str} modificada con exito");
            }
            Console.ReadKey();
        }

        public override void Remover()
        {
            Console.WriteLine("Ingrese el id del cliente a Remover");
            _customersLogic.Delete(Utilidades.LeerTexto());
            Console.WriteLine("Se removio correctamente");
            Console.ReadKey();
        }

        public override void VerDetalle()
        {

            Console.WriteLine("Ingrese el ID del CLiente a consultar:");
            var customer = Buscar();
            Console.WriteLine(customer.CustomerID);
            Console.ReadKey();

        }

        public override void VerTodos()
        {
            Console.WriteLine("** Mostrando categorias **");
            foreach (Customers c in _customersLogic.GetAll())
            {
                Console.WriteLine($"Nombre: {c.CompanyName} ID: {c.CustomerID}");
            }
            Console.ReadKey();

        }
        private Customers Buscar()
        {
            var id = Utilidades.LeerTexto();
            var customer = _customersLogic.Find(id);
            return customer;
        }
    }
}
