using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class MethodSyntax : BaseQuery, IQuerys
    {
        public Customers Ejercicio1() 
        { 
               return northwindContext.Customers.FirstOrDefault();
        }

        public IEnumerable<Products> Ejercicio2()
        {
            return northwindContext.Products.Where(p => p.UnitsInStock == 0);
        }

        public IEnumerable<Products> Ejercicio3() 
        {
            return northwindContext.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
        }

        public IEnumerable<Customers> Ejercicio4()
        {
            return northwindContext.Customers.Where(c => c.Region == "wa");
        }

        public Products Ejercicio5()
        {
            return northwindContext.Products.FirstOrDefault(p => p.ProductID == 789 );
        }

        public IEnumerable<string> Ejercicio6()
        {
            return northwindContext.Customers.Select(p => p.CompanyName.ToLower() + p.CompanyName.ToLower());
        }

        public IEnumerable<CustomerOrder> Ejercicio7()
        {
            return northwindContext.Customers.Join(northwindContext.Orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new CustomerOrder
                {
                    CustomerCompanyName = c.CompanyName,
                    CustomerRegionName = c.Region,
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate
                }).Where(d => d.CustomerRegionName == "WA" && d.OrderDate > new DateTime(1997, 1, 1))
                .OrderBy(d => d.CustomerCompanyName);
        }
        public IEnumerable<Customers> Ejercicio8()
        {
            return northwindContext.Customers.Where(c => c.Region == "WA").Take(3);
        }

        public IEnumerable<Products> Ejercicio9()
        {
            return northwindContext.Products.OrderBy(c => c.ProductName);
        }
        public IEnumerable<Products> Ejercicio10()
        {
            return northwindContext.Products.OrderByDescending(p => p.UnitsInStock);
        }

        public IEnumerable<Categories> Ejercicio11()
        {
            return northwindContext.Categories.Where(p => p.Products.Any());
        }

        public Products Ejercicio12()
        {
            return northwindContext.Products.First();
        }

        public IEnumerable<CustomerDTO> Ejercicio13()
        {
            return northwindContext.Customers.Select(c => new CustomerDTO
            {
                ContactName = c.ContactName,
                CantOrdenes = c.Orders.Count,
            });
        }
    }
}
