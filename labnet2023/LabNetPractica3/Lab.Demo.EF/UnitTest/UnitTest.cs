using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab.Demo.EF.Logic;
using Lab.Demo.EF.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Moq;
using Lab.Demo.EF.Data;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]  
        public void Prueba1()
        {
            var data = new List<Customers>
            {
                new Customers
                {
                    CustomerID = "AVSD",
                    CompanyName = "AVES VUELAN SIN DESPREOCUPACION"
                }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Customers>>();
            mockSet.As<IQueryable<Customers>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);

            CustomersLogic customersLogic = new CustomersLogic(mockContext.Object);

            customersLogic.Find("anach");
            
        }
    }
}
