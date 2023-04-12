﻿using System.ComponentModel.DataAnnotations;

namespace AceApp.Models
{
    public class PropertyClaim
    {
        public long Id { get; set; }
        [MaxLength(450)]
        public string UserId { get; set; }
        [MaxLength(250)]
        public string CompanyName { get; set; }
        [MaxLength(250)]
        public string SubmittedBy { get; set; }
        [MaxLength(250)]
        public string AceNo { get; set; }
        [MaxLength(250)]
        public string Office { get; set; }
        [MaxLength(16)]
        public string WorkPhone { get; set; }
        [MaxLength(16)]
        public string Extension { get; set; }
        [MaxLength(16)]
        public string FaxNumber { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }

        // Claim part
        [MaxLength(100)]
        public string ClaimNo { get; set; }
        [MaxLength(800)]
        public string DescriptionOfLoss { get; set; }
        public int PolicyType { get; set; }
        [MaxLength(250)]
        public string PolicyNumber { get; set; }
        public DateTime? DayOfLoss { get; set; }

        // Insured 
        [MaxLength(250)]
        public string InsuredLastNameOrBusinessName { get; set; }
        [MaxLength(250)]
        public string InsuredFirstName { get; set; }
        public bool InsuredSamePropertyOwner { get; set; }

        // Vehicle owner
        [MaxLength(250)]
        public string PropertyOwnerLastNameOrBusinessName { get; set; }
        [MaxLength(250)]
        public string PropertyOwnerFirstName { get; set; }
        [MaxLength(24)]
        public string PropertyOwnerState { get; set; }
        [MaxLength(32)]
        public string PropertyOwnerZipCode { get; set; }

        [MaxLength(750)]
        public string ClaimComments { get; set; }

        // Contact Part
        [MaxLength(150)]
        public string ContactShopName { get; set; }
        [MaxLength(16)]
        public string ContactPhoneNumber { get; set; }
        public bool IsReachAgreement { get; set; }
        public bool IsPermittedGatherMoreInfo { get; set; }

        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
