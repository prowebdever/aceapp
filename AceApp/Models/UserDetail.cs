using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AceApp.Models
{
    public partial class UserDetail
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string UserId { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string CompanyName { get; set; }
        [MaxLength(100)]
        public string Office { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(16)]
        public string PhoneNumber { get; set; }
        [MaxLength(16)]
        public string FaxNumber { get; set; }
        [MaxLength(16)]
        public string Extension { get; set; }
        [MaxLength(250)]
        public string Avtar { get; set; }
        public bool? IsBlock { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        
        public virtual AspNetUsers User { get; set; }
    }
}
