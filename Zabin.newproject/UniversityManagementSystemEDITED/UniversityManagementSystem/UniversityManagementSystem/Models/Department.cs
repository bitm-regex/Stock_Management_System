using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Department Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Department Code")]
        [StringLength(7,MinimumLength =2,ErrorMessage ="Department Code Must be 2-7 charecter long")]
        public string Code { get; set; }
    }
}