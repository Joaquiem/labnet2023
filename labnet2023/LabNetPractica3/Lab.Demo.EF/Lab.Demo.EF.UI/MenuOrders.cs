using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;



namespace Lab.Demo.EF.UI
{
    internal class MenuOrders : MenuBase
    {
        OrdersLogic _ordersLogic = new OrdersLogic();
        public override void Agregar()
        {
            Orders order = new Orders();
            Console.WriteLine("Agregar una Orden");
            order.OrderID = Utilidades.LeerNumero();
            _ordersLogic.Insert(order);
            Console.WriteLine($"Orden {order.OrderID} agregada con exito");
            Console.ReadKey();
        }

        public override void Modificar()
        {
            Console.WriteLine("Ingrese el id de la orden a Modificar");
            var orden = Buscar();
            Console.WriteLine("Orden a modificar:\n" + orden);
            Console.WriteLine("Ingrese nuevo id del empleado o ingrese 0 para salir:");
            string str = Utilidades.LeerTexto();
            if (str != "0")
            {
                orden.EmployeeID = int.Parse(str);
                _ordersLogic.Update(orden);
                Console.WriteLine($"Id empleado {str} modificada con exito");
                Console.ReadKey();
            }
        }

        public override void Remover()
        {
            Console.WriteLine("Ingrese el ID de la orden a Remover");
            _ordersLogic.Delete(Utilidades.LeerNumero());
            Console.WriteLine($"La orden ha sido removida con exito");
            Console.ReadKey();
        }

        public override void VerDetalle()
        {
            Console.WriteLine("Ingrese el ID de la orden a consultar:");
            var order = Buscar();
            Console.WriteLine(order.OrderID);
            Console.ReadKey();
        }

        public override void VerTodos()
        {
            Console.WriteLine("** Mostrando categorias **");
            foreach (Orders o in _ordersLogic.GetAll())
            {
                Console.WriteLine($"Detalles: {o.Order_Details} ID: {o.OrderID}");
            }
            Console.ReadKey();
        }
        private Orders Buscar()
        {
            var id = Utilidades.LeerNumero();
            var category = _ordersLogic.Find(id);
            return category;
        }
    }
}
