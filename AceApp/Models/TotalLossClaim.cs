using System.ComponentModel.DataAnnotations;

namespace AceApp.Models
{
    public class TotalLossClaim
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
        public string ClaimantLastNameOrBusinessName { get; set; }
        [MaxLength(250)]
        public string ClaimantOwnerFirstName { get; set; }
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
        [MaxLength(100)]
        public string VehicleOdometer { get; set; }
        [MaxLength(100)]
        public string VehicleState { get; set; }

        // Details optins
        [MaxLength(650)]
        public string PowerOptions { get; set; }
        [MaxLength(650)]
        public string Radios { get; set; }
        [MaxLength(650)]
        public string Seats { get; set; }
        [MaxLength(650)]
        public string Decors { get; set; }
        [MaxLength(650)]
        public string Safetys { get; set; }
        [MaxLength(650)]
        public string Wheels { get; set; }
        [MaxLength(650)]
        public string Conveniences { get; set; }
        [MaxLength(650)]
        public string Roofs { get; set; }
        [MaxLength(650)]
        public string Paints { get; set; }
        [MaxLength(650)]
        public string Trucks { get; set; }
        [MaxLength(650)]
        public string Motorcycles { get; set; }

        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
