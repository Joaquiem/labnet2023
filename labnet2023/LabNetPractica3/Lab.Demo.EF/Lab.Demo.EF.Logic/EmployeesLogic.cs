using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees, int>
    {
        public EmployeesLogic() { }
        public EmployeesLogic(NorthwindContext context) 
        {
            this.context = context;
        }
        public void Delete(int tid)
        {
            var employeeAEliminar = context.Employees.First(e => e.EmployeeID == tid);
            context.Employees.Remove(employeeAEliminar);
            context.SaveChanges(); 
        }

        public Employees Find(int id)
        {
            var employee = context.Employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null)
            {
                throw new ArgumentException($"Empleado con el id: {id} no encontrado");
            }
            return employee;
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Insert(Employees t)
        {
            if (context.Employees.FirstOrDefault(e => e.EmployeeID == t.EmployeeID) != null) 
            {
                throw new ArgumentException("Empleado ya registrado");
            }
            context.Employees.Add(t);
            context.SaveChanges();
        }

        public void Update(Employees t)
        {
            var employeeUpdate = context.Employees.Find(t.EmployeeID);
            employeeUpdate.FirstName = t.FirstName;
            context.SaveChanges();
        }
    }
}
