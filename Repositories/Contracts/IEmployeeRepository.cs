using System.Collections.Generic;
using HumanResourcesSystem.Models;

namespace HumanResourcesSystem.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int employeeId);
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}
