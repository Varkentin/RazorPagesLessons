
using System.ComponentModel.DataAnnotations;


namespace RazorPagesLessons.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field cannot be null! Please, write the Name")]
        [MinLength(2), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email format")]
        [MinLength(2), MaxLength(50)]
        public string Email { get; set; }

        public string PhotoPath { get; set; }
        [Required]
        public Dept? Department { get; set; }
    }
}
