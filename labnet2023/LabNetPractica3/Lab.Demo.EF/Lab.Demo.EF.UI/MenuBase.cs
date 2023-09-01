using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    public abstract class MenuBase
    {
        private static int _cantMetodos = 5;
        public abstract void VerTodos();
        public abstract void VerDetalle();
        public abstract void Agregar();
        public abstract void Remover();
        public abstract void Modificar();
        public void Ejecutar()
        {
            int seleccion;
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "Que desea hacer:" +
                    "\n1- Ver todos los registros" +
                    "\n2- Ver detalle de un registro" +
                    "\n3- Agregar un registro" +
                    "\n4- Remover un registro" +
                    "\n5- Modificar un registro" +
                    "\n0- Volver al menu principal");
                seleccion = Utilidades.LeerNumero(MenuBase._cantMetodos);

                try
                {
                    switch (seleccion)
                    {
                        case 1:
                            VerTodos();
                            break;
                        case 2:
                            VerDetalle();
                            break;
                        case 3:
                            Agregar();
                            break;
                        case 4:
                            Remover();
                            break;
                        case 5:
                            Modificar();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\npresione enter para volver al menu");
                    Console.ReadKey();
                }
            } while (seleccion != 0);
        }
    }
}
