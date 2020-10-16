using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesLessons.Models;
using RazorPagesLessons.Services;

namespace RazorPagesGeneral.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public EditModel(IEmployeeRepository employeeRepository, IWebHostEnvironment webHostEnvironment)
        {
            _employeeRepository = employeeRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }
        
        [BindProperty]
        public bool Notify { get; set; }

        public string Massage { get; set; }



        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
                Employee = _employeeRepository.GetEmployee(id.Value);
            else
                Employee = new Employee();

            if (Employee == null)
                RedirectToPage("/NotFound");
            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                if(Photo!= null)
                {
                    if(Employee.PhotoPath != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", Employee.PhotoPath);

                        if (Employee.PhotoPath != "noimage.png")
                        {
                            System.IO.File.Delete(filePath);
                        }
                    }

                    Employee.PhotoPath = ProcessUploadFile();
                }

                if(Employee.Id>0)
                { 
                Employee = _employeeRepository.Update(Employee);

                TempData["SuccessMessage"] = $"Update {Employee.Name} Successful!"; 
                
                }
                else
                {
                    Employee = _employeeRepository.Add(Employee);

                    TempData["SuccessMessage"] = $"Adding {Employee.Name} Successful!";

                }

                return RedirectToPage("Employees");
               
            }
            
                return Page();

        }

        public void OnPostUpdateNotificationPerfernces(int id)
        {
            if (Notify)
                Massage = "Thank you for turning notifications";
            else
                Massage = "You have turned off email notifications";

            Employee = _employeeRepository.GetEmployee(id);

        }

        private string ProcessUploadFile()
        {
            string uniqueFileName = null;
            if(Photo != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath,"images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
