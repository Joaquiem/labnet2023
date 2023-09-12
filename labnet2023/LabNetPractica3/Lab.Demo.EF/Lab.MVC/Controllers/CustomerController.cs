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


        [HttpPost]
        public ActionResult Delete(string id) 
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("index");
            }
            catch(Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpGet]
        public ActionResult Update(string id)
        {
            try
            {
                Customers c = logic.Find(id);

                CustomerView ret = new CustomerView
                {
                    ID = c.CustomerID,
                    CompanyName = c.CompanyName,
                   
                };

                return View(ret);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpPost]
        public ActionResult Update(CustomerView customerView) 
        {
            try
            {
                Customers category = new Customers
                {
                    CustomerID = customerView.ID,
                    CompanyName = customerView.CompanyName
                     
                };

                logic.Update(category);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }
    }
}