using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MethodSyntax m = new MethodSyntax();
            QuerySyntax q = new QuerySyntax();

            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Query syntax");
            Console.WriteLine(q.Ejercicio1().CustomerID);
            Console.WriteLine("Method syntax");
            Console.WriteLine(m.Ejercicio1().CustomerID);


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio2()) 
            {
                Console.WriteLine($"{qq.UnitsInStock} {qq.ProductName}");
            }
           
            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio2())
            {
                Console.WriteLine($"{mm.UnitsInStock} {mm.ProductName}");
            };


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio3())
            {
                Console.WriteLine($"{qq.UnitPrice} {qq.UnitsInStock} {qq.ProductName}");
            }

            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio3())
            {
                Console.WriteLine($"{mm.UnitPrice} {mm.UnitsInStock} {mm.ProductName}");
            };


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio4())
            {
                Console.WriteLine($"{qq.Region} {qq.CompanyName}");
            }

            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio4())
            {
                Console.WriteLine($"{mm.Region} {mm.CompanyName}");
            };


            Console.ReadKey();
            Console.Clear();
          
            Console.WriteLine("Ejercicio 5");
            Console.WriteLine("Query syntax");
            if (!(q.Ejercicio5() == null)) { Console.WriteLine($"{q.Ejercicio5().ProductName} "); }

            Console.WriteLine("Method syntax");
            if (!(m.Ejercicio5() == null)) { Console.WriteLine($"{m.Ejercicio5().ProductName} "); }
           
           

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 6");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio6())
            {
                Console.WriteLine(qq);
            }

            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio6())
            {
                Console.WriteLine(mm);
            };


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 7");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio7())
            {
                Console.WriteLine($"{qq.CustomerCompanyName} {qq.OrderDate}");
            }

            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio7())
            {
                Console.WriteLine($"{mm.CustomerCompanyName} {mm.OrderDate}");
            };


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 8");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio8())
            {
                Console.WriteLine($"{qq.CompanyName}   {qq.CustomerID}");
            }

            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio8())
            {
                Console.WriteLine($"{mm.CompanyName}   {mm.CustomerID}");
            };


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 9");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio9())
            {
                Console.WriteLine(qq.ProductName);
            }

            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio9())
            {
                Console.WriteLine(mm.ProductName);
            };


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 10");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio10())
            {
                Console.WriteLine($"{qq.UnitsInStock} {qq.ProductName}");
            }

            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio10())
            {
                Console.WriteLine($"{mm.UnitsInStock} {mm.ProductName}");
            }; 


            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 11");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio11())
            {
                Console.WriteLine($"{qq.CategoryName.ToString()} {qq.Products.ToString()}");
            }
            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio11())
            {
                Console.WriteLine($"{mm.CategoryName} {mm.Products}");
            };

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 12");
            Console.WriteLine("Query syntax");
            Console.WriteLine(q.Ejercicio12().ProductName);
            Console.WriteLine("Method syntax");
            Console.WriteLine(m.Ejercicio12().ProductName);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 13");
            Console.WriteLine("Query syntax");
            foreach (var qq in q.Ejercicio13())
            {
                Console.WriteLine($"{qq.ContactName} {qq.CantOrdenes}");
            }
            Console.WriteLine("Method syntax");
            foreach (var mm in m.Ejercicio13())
            {
                Console.WriteLine($"{mm.ContactName} {mm.CantOrdenes}");
            };


        }
    }
}
