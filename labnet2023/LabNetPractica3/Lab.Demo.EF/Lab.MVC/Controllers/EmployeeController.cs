using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeesLogic logic = new EmployeesLogic();
        // GET: Employee
        public ActionResult Index()
        {
            var employees = logic.GetAll();
            List<EmployeeView> employeeView = employees.Select(e => new EmployeeView
            {
                EmployeeID = e.EmployeeID,
                FirstName = e.FirstName,
                LastName = e.LastName,
            }).ToList();


            return View(employeeView);
        }

        public ActionResult Insert()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Insert(EmployeeView ev)
        {
            try
            {
                Employees employeeEntity = new Employees
                {
                    EmployeeID = ev.EmployeeID,
                    FirstName = ev.FirstName,
                    LastName = ev.LastName
                };

                logic.Insert(employeeEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }


        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                Employees e = logic.Find(id);

                EmployeeView ret = new EmployeeView
                {
                    EmployeeID = e.EmployeeID,
                    FirstName = e.FirstName,
                    LastName = e.LastName,

                };

                return View(ret);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpPost]
        public ActionResult Update(EmployeeView employeeView)
        {
            try
            {
                Employees employee = new Employees
                {
                    EmployeeID = employeeView.EmployeeID,
                    FirstName = employeeView.FirstName,
                    LastName = employeeView.LastName,

                };

                logic.Update(employee);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }
    }
}