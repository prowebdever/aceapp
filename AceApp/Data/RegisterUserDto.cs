using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AceApp.Data
{
    public class RegisterUserDto
    {
        [Required(ErrorMessage = "Company Name is required.")]
        public string CompanyName { get; set; }
        
        [Required(ErrorMessage = "Office is required.")]
        public string Office { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        [Remote("IsAlreadyNameSigned", "Account", HttpMethod = "POST", ErrorMessage = "User Name already exists in database.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Email is required.")]
        [Remote("IsAlreadySigned", "Account", HttpMethod = "POST", ErrorMessage = "Email already exists in database.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{3}?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Phone number should be like 123-345-6789")]
        public string PhoneNumber { get; set; }

        public string Extension { get; set; }

        [Required(ErrorMessage = "Fax number is required.")]
        [RegularExpression(@"^\d{3}?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Fax number should be like 123-345-6789")]
        public string FaxNumber { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d].{8,}$", ErrorMessage = "Password Should contain atleast 8 characters with 1 number,1 lowercase and 1 uppercase character")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
