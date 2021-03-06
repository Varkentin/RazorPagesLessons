﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesLessons.Models;
using RazorPagesLessons.Services;

namespace RazorPagesGeneral.ViewComponents
{
    [ViewComponent(Name = "HeadCount")]
    public class HeadCountViewComponent : ViewComponent
    {
        private readonly IEmployeeRepository _employeeRepository;


        public HeadCountViewComponent(IEmployeeRepository  employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IViewComponentResult Invoke(Dept? department = null)
        {
            IEnumerable<DeptHeadCount> result = _employeeRepository.EmployeeCountByDept(department);
            return View(result);
        }
    }
}
