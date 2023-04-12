using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AceApp.Data
{
    public class PropertyClaimDto
    {
        public int Id { get; set; }

        // Company part
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Submitted By is required.")]
        public string SubmittedBy { get; set; }
        public string AceNo { get; set; }
        public string Office { get; set; }
        public string WorkPhone { get; set; }
        public string Extension { get; set; }
        public string FaxNumber { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        // Claim part
        [Required(ErrorMessage = "ClaimNo is required.")]
        public string ClaimNo { get; set; }
        [Required(ErrorMessage = "Description of loss is required.")]
        public string DescriptionOfLoss { get; set; }
        public string PolicyNumber { get; set; }
        public int PolicyType { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DayOfLoss { get; set; }

        // Insured 
        [Required(ErrorMessage = "Last name or Business name is required.")]
        public string InsuredLastNameOrBusinessName { get; set; }
        public string InsuredFirstName { get; set; }
        public bool InsuredSamePropertyOwner { get; set; }

        // Property owner
        [Required(ErrorMessage = "Last name or Business name is required.")]
        public string PropertyOwnerLastNameOrBusinessName { get; set; }
        public string PropertyOwnerFirstName { get; set; }
        public string PropertyOwnerState { get; set; }
        [Required(ErrorMessage = "Zip Code is required.")]
        public string PropertyOwnerZipCode { get; set; }
        public string ClaimComments { get; set; }

        // Contact Part
        [Required(ErrorMessage = "Shop name is required.")]
        public string ContactShopName { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{3}?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Phone number should be like 123-345-6789")]
        public string ContactPhoneNumber { get; set; }
        public bool IsReachAgreement { get; set; }
        public bool IsPermittedGatherMoreInfo { get; set; }

        // Policy Types
        public string[] PolicyTypes { get; set; }
        public string[] StateNames { get; set; }
        public string[] StateValues { get; set; }
    }
}
