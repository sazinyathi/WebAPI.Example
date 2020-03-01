using ExpoloreWebAPI.Models;
using System.Collections.Generic;

namespace WebAPI.Interfaces
{
    public interface IEmployee
    {
        void CreateEmployee(Employees employees);
        Employees GetEmployeeById(int employeeId);
        IEnumerable<Employees> GetAllEmployees();
        void EditEmployee(int employeeId, Employees employees);
        void DeleteEmployee(int employeeId);
    }
}
