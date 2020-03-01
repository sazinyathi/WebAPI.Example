using ExpoloreWebAPI.Models;
using System.Collections.Generic;

namespace WebAPI.Interfaces.Services
{
    public  interface IEmployeeServices
    {
        void CreateEmployee(Employees employees);
        Employees GetEmployeeById(int employeeId);
        IEnumerable<Employees> GetAllEmployees();
        void EditEmployee(int employeeId, Employees employees);
        void DeleteEmployee(int employeeId);
    }
}


