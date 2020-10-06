using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesLessons.Models;
using RazorPagesLessons.Services;

namespace RazorPagesGeneral.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Employee { get; set; }
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);
            if (Employee == null)
                RedirectToPage("/NotFound");
            return Page();
        }
    }
}
