using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class CustomersLogic: BaseLogic, IABMLogic<Customers,string>
    {

        public CustomersLogic() { }
        public CustomersLogic(NorthwindContext context)
        {
            this.context = context;
        }

        public void Delete(string id)
        {
            try
            {
                var customerAEliminar = context.Customers.First(i => i.CustomerID == id);

                context.Customers.Remove(customerAEliminar);
                context.SaveChanges();
            }
            catch (Exception e)
            { 
                
            }

        }
        public Customers Find(string id)
        {
            var customer = context.Customers.FirstOrDefault(c => c.CustomerID == id);
            if (customer == null)
            {
                throw new ArgumentException($"Cliente con el id: {id} no encontrado");
            }
            return customer;
        }
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        

        public void Insert(Customers customer) 
        {
            if (context.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID) != null)
            {
                throw new ArgumentException("Cliente ya registrado");
            }
            context.Customers.Add(customer);
            context.SaveChanges();
        }
      
        public void Update(Customers customer)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);

            customerUpdate.CompanyName = customer.CompanyName;
            context.SaveChanges();
        }

    }
}
