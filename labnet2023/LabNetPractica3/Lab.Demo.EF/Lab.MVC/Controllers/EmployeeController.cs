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
                ID = e.EmployeeID,
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
                    EmployeeID = ev.ID,
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
        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}