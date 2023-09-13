using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Lab.EF.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Lab.EF.Api.Controllers
{

    public class EmployeeController : ApiController
    {
        // GET: Employee

        readonly EmployeesLogic _employeeLogic = new EmployeesLogic();
        // GET: Customer
        public IHttpActionResult Get()
        {
            try
            {
                var ret = _employeeLogic.GetAll().Select(c => new EmployeeDTO
                {
                    EmployeeID = c.EmployeeID,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                });
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult Get(int id)
        {
            try
            {
                var aux = _employeeLogic.Find(id);
                var ret = new EmployeeDTO
                {
                    EmployeeID = aux.EmployeeID,
                    FirstName = aux.FirstName,
                    LastName = aux.LastName,
                };
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult Post([FromBody] EmployeeDTO e)
        {
            try
            {
                Employees aux = new Employees
                {
                    EmployeeID = e.EmployeeID,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                };
                _employeeLogic.Insert(aux);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Put(string id, [FromBody] EmployeeDTO e)
        {
            try
            {
                Employees aux = new Employees
                {
                    EmployeeID = e.EmployeeID,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                };
                _employeeLogic.Insert(aux);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                _employeeLogic.Delete(id);
                return Ok();
            }
            catch
            (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }

}