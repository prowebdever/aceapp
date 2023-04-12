using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AceApp.Data
{
    public class ContactUsDto
    {
        
        
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Description of issue is required.")]
        public string Description { get; set; }
    }
}
