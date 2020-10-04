using RazorPagesLessons.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesLessons.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee
                {
                    Id= 0, Name = "Mary", Email = "mary@gmail.com", PhotoPath = "avatar1.png", Department = Dept.HR
                },
                new Employee
                {
                    Id= 1, Name = "Gary", Email = "gary@gmail.com", PhotoPath = "avatar2.png", Department = Dept.IT
                },
                new Employee
                {
                    Id= 0, Name = "Ben", Email = "ben@gmail.com", PhotoPath = "avatar3.png", Department = Dept.IT
                },
                new Employee
                {
                    Id= 0, Name = "Den", Email = "den@gmail.com", PhotoPath = "avatar4.png", Department = Dept.Payroll
                },
                new Employee
                {
                    Id= 0, Name = "Jess", Email = "jessgmail.com", PhotoPath = "avatar5.png", Department = Dept.HR
                },
                new Employee
                {
                    Id= 0, Name = "Andry", Email = "andry@gmail.com",  Department = Dept.Payroll
                }
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
           return _employeeList;
        }
    }
}
