using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Lab.MVC.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class CustomerController : Controller
    {
        CustomersLogic logic = new CustomersLogic();

        // GET: Customer


        public ActionResult Index()
        {
            var customers = logic.GetAll(); 
            List<CustomerView> customerView = customers.Select(c => new CustomerView
            {
                ID = c.CustomerID,
                CompanyName = c.CompanyName,
            }).ToList();
            

            return View(customerView);
        }
        public ActionResult Insert() 
        {

            return View();
        }
        [HttpPost]
        public ActionResult Insert(CustomerView cv) 
        {
            try
            {
                Customers orderEntity = new Customers
                {
                    CustomerID = cv.ID,
                    CompanyName = cv.CompanyName
                };

                logic.Insert(orderEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }


        }
        public ActionResult Delete(string id) 
        {
            logic.Delete(id);
            return RedirectToAction("index");
        }
    }
}