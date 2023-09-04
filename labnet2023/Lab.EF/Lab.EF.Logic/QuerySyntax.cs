using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class QuerySyntax: BaseQuery, IQuerys
    {
        public Customers Ejercicio1()
        {
            return (from Customers in northwindContext.Customers  
                    select Customers).First();
        }

        public IEnumerable<Products> Ejercicio2()
        {
            return (from Products in northwindContext.Products
                    where Products.UnitsInStock == 0
                    select Products);
        }

        public IEnumerable<Products> Ejercicio3()
        {
            return(from Products in northwindContext.Products
                   where Products.UnitsInStock > 0 && Products.UnitPrice >3
                   select Products);
        }

        public IEnumerable<Customers> Ejercicio4()
        {
            return (from Customers in northwindContext.Customers
                    where Customers.Region == "WA"
                    select Customers);
        }

        public Products Ejercicio5()
        {
            return (from products in northwindContext.Products
                    where products.ProductID == 789
                    select products).FirstOrDefault();
        }

        public IEnumerable<string> Ejercicio6()
        {
            return (from Customers in northwindContext.Customers
                    select (Customers.CompanyName.ToUpper() + Customers.CompanyName.ToLower()));
        }

        public IEnumerable<CustomerOrder> Ejercicio7()
        {
            
            return (from c in northwindContext.Customers
                    join o in northwindContext.Orders on c.CustomerID equals o.CustomerID
                    where c.Region == "Wa" && o.OrderDate > new DateTime(1997, 1, 1)
                    select new CustomerOrder { 
                           CustomerCompanyName = c.CompanyName,
                           CustomerRegionName = c.Region,
                           OrderID = o.OrderID,
                           OrderDate = o.OrderDate                   
                    });
        }
        
        public IEnumerable<Customers> Ejercicio8()
        {
            return (from c in northwindContext.Customers
                    where c.Region == "WA"
                    select c).Take(3);
        }

        public IEnumerable<Products> Ejercicio9()
        {
            return (from p in northwindContext.Products
                       orderby p.ProductName
                       select p);
        }

        public IEnumerable<Products> Ejercicio10()
        {
            return from p in northwindContext.Products
                   orderby p.UnitsInStock descending
                   select p;
        }

        public IEnumerable<Categories> Ejercicio11()
        {
            return from c in northwindContext.Categories
                   where c.Products.Any()
                   select c;
        }

        public Products Ejercicio12()
        {
            return (from p in northwindContext.Products
                   select p).First();
        }
        
        public IEnumerable<CustomerDTO> Ejercicio13()
        {
            return (from c in northwindContext.Customers
                    select new CustomerDTO
                    {
                        ContactName = c.ContactName,
                        CantOrdenes = c.Orders.Count()
                    }); ;
        }
    }
}
