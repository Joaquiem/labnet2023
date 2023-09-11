using Lab.Demo.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class OrderController : Controller
    {
        OrdersLogic logic = new OrdersLogic();
        // GET: Order
        public ActionResult Index()
        {
            var order = logic.GetAll();
            List<OrderView> orderView = order.Where(o => o.Customers != null).Select(o => new OrderView
            {
                Id = o.OrderID,
                CompanyName = o.Customers.CompanyName,
                CompanyId = o.Customers.CustomerID
                
            }).ToList() ; 

            return View(order);
        }
    }
}