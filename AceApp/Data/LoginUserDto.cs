using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AceApp.Data
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "UserID is required.")]
        public string UserID { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

    }
}
