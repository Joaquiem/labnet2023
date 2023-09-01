using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
     public class OrdersLogic : BaseLogic, IABMLogic<Orders,int>
     {

        public OrdersLogic() { }
        public OrdersLogic(NorthwindContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            var orderAEliminar = context.Orders.First(i => i.OrderID == id);

            context.Orders.Remove(orderAEliminar);
            context.SaveChanges();
        }

        public Orders Find(int id)
        {

            var order = context.Orders.FirstOrDefault(o => o.OrderID == id);

            if (order == null)
            {
                throw new ArgumentException($"Orden con el id {id} no encontrada");
            }
                return order;
            
        }
        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }


        public void Insert(Orders orders)
         {
            context.Orders.Add(orders);
            context.SaveChanges();
         }

         public void Update( Orders order) {

            var orderUpdate = context.Orders.Find(order.OrderID);

            orderUpdate.EmployeeID = order.EmployeeID;   
            context.SaveChanges();
        }
    }
}
