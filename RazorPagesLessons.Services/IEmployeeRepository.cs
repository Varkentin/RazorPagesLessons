using RazorPagesLessons.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesLessons.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Search(string searchTrem);

        IEnumerable<Employee> GetAllEmployees();
        
        Employee GetEmployee(int id);

        Employee Update(Employee updatedEmployee);

        Employee Add(Employee newEmployee);

        Employee Delete(int id);

        IEnumerable<DeptHeadCount> EmployeeCountByDept(Dept? dept);
    }
}
