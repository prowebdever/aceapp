using System.ComponentModel.DataAnnotations;

namespace AceApp.Models
{
    public class PhotoQuoteClaim
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
        public int LossType { get; set; }
        [MaxLength(250)]
        public string PolicyNumber { get; set; }
        [MaxLength(250)]
        public string Deductible { get; set; }
        public DateTime? DayOfLoss { get; set; }

        // Insured 
        [MaxLength(250)]
        public string InsuredLastNameOrBusinessName { get; set; }
        [MaxLength(250)]
        public string InsuredFirstName { get; set; }
        public bool InsuredSameVehicleOwner { get; set; }

        // Vehicle owner
        [MaxLength(250)]
        public string VehicleOwnerLastNameOrBusinessName { get; set; }
        [MaxLength(250)]
        public string VehicleOwnerFirstName { get; set; }
        [MaxLength(32)]
        public string VehicleOwnerZipCode { get; set; }
        [MaxLength(32)]
        public string VehiclePhoneNumber { get; set; }
        public bool IsReceiveSMS { get; set; }

        [MaxLength(750)]
        public string ClaimComments { get; set; }

        // Vehicle part
        [MaxLength(50)]
        public string VehicleNo { get; set; }
        [MaxLength(4)]
        public string VehicleYear { get; set; }
        [MaxLength(50)]
        public string VehicleMake { get; set; }
        [MaxLength(50)]
        public string VehicleModel { get; set; }
        
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
