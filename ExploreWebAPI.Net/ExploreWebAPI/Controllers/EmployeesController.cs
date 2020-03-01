using ExpoloreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Interfaces.Services;
using WebAPI.Services;

namespace ExploreWebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeServices _employeeServices;
        public EmployeesController()
        {
            _employeeServices = new EmployeesService();
        }
        // GET: api/Employees
        public IEnumerable<Employees> Get()
        {
            return _employeeServices.GetAllEmployees();
        }

        // GET: api/Employees/5
        public Employees Get(int id)
        {
            return _employeeServices.GetEmployeeById(id);
        }

        // POST: api/Employees
        public void Post([FromBody]Employees employees)
        {
            _employeeServices.CreateEmployee(employees);
        }

        // PUT: api/Employees/5
        public void Put(int id, [FromBody]Employees employees)
        {
            _employeeServices.EditEmployee(id, employees);
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
            _employeeServices.DeleteEmployee(id);
        }
    }
}
