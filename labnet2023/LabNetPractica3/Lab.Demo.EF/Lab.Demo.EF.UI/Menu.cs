using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    public static class Menu
    {
        private static readonly int _catnEntidades = 2;
        public static void MenuInteractivo() {
            int seleccion;
            MenuBase menu = null;
            do
            {
                Console.WriteLine(
                    "Elija con que entidad quiere interactuar " +
                    "\n1- Orders (ordenes)" +
                    "\n2- Customers (clientes)" +
                    "\n0- Terminar la aplicacion");
                seleccion = Utilidades.LeerNumero(_catnEntidades);

                switch (seleccion)
                {
                    case 1:
                            menu= new MenuOrders();
                        break;
                    case 2:
                        menu= new MenuCustomers();
                        break;
                }
                if (menu != null) 
                { 
                    menu.Ejecutar();
                    menu = null;
                }
                Console.Clear();
            } while (seleccion != 0);
        }
        
    }
}
