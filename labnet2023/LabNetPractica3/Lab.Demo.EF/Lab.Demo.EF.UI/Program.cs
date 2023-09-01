using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF.Logic;
using Lab.Demo.EF.Entities;

namespace Lab.Demo.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estas accediendo a la base de datos de northwind");

            Menu.MenuInteractivo();
        }
    }
}
