using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Lab.EF.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Lab.EF.Api.Controllers
{
    public class CustomerController : ApiController
    {
        readonly CustomersLogic _customersLogic = new CustomersLogic();
        // GET: Customer
        public IHttpActionResult Get()
        {
            try
            {
                var ret = _customersLogic.GetAll().Select(c => new CustomerDTO
                {
                    ID = c.CustomerID,
                    CompanyName = c.CompanyName,
                });
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult Get(string id)
        {
            try
            {
                var aux = _customersLogic.Find(id);
                var ret = new CustomerDTO
                {
                    ID = aux.CustomerID,
                    CompanyName = aux.CompanyName,
                };
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IHttpActionResult Post([FromBody] CustomerDTO c)
        {
            try
            {
                Customers aux = new Customers
                {
                    CustomerID = c.ID,
                    CompanyName = c.CompanyName
                };
                _customersLogic.Insert(aux);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Put(string id, [FromBody] CustomerDTO c)
        {
            try
            {
                Customers aux = new Customers
                {
                    CustomerID = c.ID,
                    CompanyName = c.CompanyName
                };
                _customersLogic.Insert(aux);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IHttpActionResult Delete(string id)
        {
            try
            {
                _customersLogic.Delete(id);
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