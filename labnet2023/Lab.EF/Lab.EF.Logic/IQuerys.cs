using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.EF.Entities;

namespace Lab.EF.Logic
{
    public interface IQuerys
    {
        Customers Ejercicio1();
        IEnumerable<Products> Ejercicio2();
        IEnumerable<Products> Ejercicio3();
        IEnumerable<Customers> Ejercicio4();
        Products Ejercicio5();
        IEnumerable<string> Ejercicio6();
        IEnumerable<CustomerOrder> Ejercicio7();
        IEnumerable<Customers> Ejercicio8();
        IEnumerable<Products> Ejercicio9();
        IEnumerable<Products> Ejercicio10();
        IEnumerable<Categories> Ejercicio11();
        Products Ejercicio12();
        IEnumerable<CustomerDTO> Ejercicio13();
    }
}
