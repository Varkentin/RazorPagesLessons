using RazorPagesLessons.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesLessons.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);

        Employee Update(Employee updatedEmployee);

        Employee Add(Employee newEmployee);


    }
}
