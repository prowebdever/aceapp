using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AceApp.Data
{
    public class TotalLossClaimDto
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
        public string Deductible { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DayOfLoss { get; set; }

        // Insured 
        [Required(ErrorMessage = "Last name or Business name is required.")] 
        public string InsuredLastNameOrBusinessName { get; set; }
        public string InsuredFirstName { get; set; }
        public bool InsuredSameVehicleOwner { get; set; }
        // Claimant
        [Required(ErrorMessage = "Last name or Business name is required.")]
        public string ClaimantLastNameOrBusinessName { get; set; }
        public string ClaimantOwnerFirstName { get; set; }

        // Vehicle part
        public string VehicleNo { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public string VehicleYear { get; set; }
        [Required(ErrorMessage = "Make is required.")]
        public string VehicleMake { get; set; }
        [Required(ErrorMessage = "Model is required.")]
        public string VehicleModel { get; set; }
        public string VehicleOdometer { get; set; }
        public string VehicleState { get; set; }

        // Details Part
        
        public string ClaimComments { get; set; }

        public List<SelectListItem> PowerOptionList { get; set; }
        public List<SelectListItem> RadioList { get; set; }
        public List<SelectListItem> SeatsList { get; set; }
        public List<SelectListItem> DecorList { get; set; }
        public List<SelectListItem> SafetyList { get; set; }
        public List<SelectListItem> WheelsList { get; set; }
        public List<SelectListItem> ConvenienceList { get; set; }
        public List<SelectListItem> RoofList { get; set; }
        public List<SelectListItem> PaintList { get; set; }
        public List<SelectListItem> TruckList { get; set; }
        public List<SelectListItem> MotorcycleList { get; set; }

        public string[] StateNames { get; set; }
        public string[] StateValues { get; set; }

        public string[] PowerOptions { get; set; }
        public string[] Radios { get; set; }
        public string[] Seats { get; set; }
        public string[] Decors { get; set; }
        public string[] Safetys { get; set; }
        public string[] Wheels { get; set; }
        public string[] Conveniences { get; set; }
        public string[] Roofs { get; set; }
        public string[] Paints { get; set; }
        public string[] Trucks { get; set; }
        public string[] Motorcycles { get; set; }
        
    }
}
