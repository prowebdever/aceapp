using AceApp.Data;
using AceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AceApp.Services
{
    public class ClaimsService : IClaimsService
    {
        private readonly AceAppDBContext _context;

        public ClaimsService(AceAppDBContext context)
        {
            _context = context;

        }
        public async Task<AutoClaim> UpsertAutoClaim(AutoClaimDto dto, string userId)
        {
            var claim = _context.AutoClaims.Where(x => x.Id == dto.Id).FirstOrDefault();
            if (claim == null)
            {
                claim = new AutoClaim
                {
                    AceNo = dto.AceNo,
                    ClaimComments = dto.ClaimComments,
                    ClaimNo = dto.ClaimNo,
                    CompanyName = dto.CompanyName,
                    ContactPhoneNumber = dto.ContactPhoneNumber,
                    ContactShopName = dto.ContactShopName,
                    DayOfLoss = dto.DayOfLoss,
                    Deductible = dto.Deductible,
                    DescriptionOfLoss = dto.DescriptionOfLoss,
                    Email = dto.Email,
                    Extension = dto.Extension,
                    FaxNumber = dto.FaxNumber,
                    InsuredFirstName = dto.InsuredFirstName,
                    InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName,
                    InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner,
                    IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo,
                    IsReachAgreement = dto.IsReachAgreement,
                    LossType = dto.LossType,
                    Office = dto.Office,
                    PolicyNumber = dto.PolicyNumber,
                    SubmittedBy = dto.SubmittedBy,
                    UserId = userId,
                    VehicleMake = dto.VehicleMake,
                    VehicleModel = dto.VehicleModel,
                    VehicleNo = dto.VehicleNo,
                    VehicleOdometer = dto.VehicleOdometer,
                    VehicleOwnerFirstName = dto.VehicleOwnerFirstName,
                    VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName,
                    VehicleYear = dto.VehicleYear,
                    WorkPhone = dto.WorkPhone,
                    IsDelete = false,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };
                await _context.AutoClaims.AddAsync(claim);
            }
            else
            {
                claim.AceNo = dto.AceNo;
                claim.ClaimComments = dto.ClaimComments;
                claim.ClaimNo = dto.ClaimNo;
                claim.CompanyName = dto.CompanyName;
                claim.ContactPhoneNumber = dto.ContactPhoneNumber;
                claim.ContactShopName = dto.ContactShopName;
                claim.DayOfLoss = dto.DayOfLoss;
                claim.Deductible = dto.Deductible;
                claim.DescriptionOfLoss = dto.DescriptionOfLoss;
                claim.Email = dto.Email;
                claim.Extension = dto.Extension;
                claim.CreatedDate = DateTime.Now;
                claim.FaxNumber = dto.FaxNumber;
                claim.InsuredFirstName = dto.InsuredFirstName;
                claim.InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName;
                claim.InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner;
                claim.IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo;
                claim.IsReachAgreement = dto.IsReachAgreement;
                claim.LossType = dto.LossType;
                claim.Office = dto.Office;
                claim.PolicyNumber = dto.PolicyNumber;
                claim.SubmittedBy = dto.SubmittedBy;
                claim.UserId = userId;
                claim.VehicleMake = dto.VehicleMake;
                claim.VehicleModel = dto.VehicleModel;
                claim.VehicleNo = dto.VehicleNo;
                claim.VehicleOdometer = dto.VehicleOdometer;
                claim.VehicleOwnerFirstName = dto.VehicleOwnerFirstName;
                claim.VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName;
                claim.VehicleYear = dto.VehicleYear;
                claim.WorkPhone = dto.WorkPhone;
                claim.UpdatedDate = DateTime.Now;
                _context.AutoClaims.Update(claim);
            }
            await _context.SaveChangesAsync();
            return await Task.FromResult(claim);
        }

        public async Task<SubrogationClaim> UpsertSubrogationClaim(SubrogationClaimDto dto, string userId)
        {
            var claim = _context.SubrogationClaims.Where(x => x.Id == dto.Id).FirstOrDefault();
            if (claim == null)
            {
                claim = new SubrogationClaim
                {
                    AceNo = dto.AceNo,
                    ClaimComments = dto.ClaimComments,
                    ClaimNo = dto.ClaimNo,
                    CompanyName = dto.CompanyName,
                    ContactPhoneNumber = dto.ContactPhoneNumber,
                    ContactAdverseFirstName = dto.ContactAdverseFirstName,
                    ContactAdverseLastNameOrBusinessName = dto.ContactAdverseLastNameOrBusinessName,
                    DayOfLoss = dto.DayOfLoss,
                    Deductible = dto.Deductible,
                    DescriptionOfLoss = dto.DescriptionOfLoss,
                    Email = dto.Email,
                    Extension = dto.Extension,
                    FaxNumber = dto.FaxNumber,
                    InsuredFirstName = dto.InsuredFirstName,
                    InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName,
                    InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner,
                    IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo,
                    IsReachAgreement = dto.IsReachAgreement,
                    LossType = dto.LossType,
                    Office = dto.Office,
                    PolicyNumber = dto.PolicyNumber,
                    SubmittedBy = dto.SubmittedBy,
                    UserId = userId,
                    VehicleMake = dto.VehicleMake,
                    VehicleModel = dto.VehicleModel,
                    VehicleNo = dto.VehicleNo,
                    VehicleOdometer = dto.VehicleOdometer,
                    VehicleOwnerFirstName = dto.VehicleOwnerFirstName,
                    VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName,
                    VehicleYear = dto.VehicleYear,
                    WorkPhone = dto.WorkPhone,
                    LiabilityPercent = dto.LiabilityPercent,
                    IsDelete = false,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };
                await _context.SubrogationClaims.AddAsync(claim);
            }
            else
            {
                claim.AceNo = dto.AceNo;
                claim.ClaimComments = dto.ClaimComments;
                claim.ClaimNo = dto.ClaimNo;
                claim.CompanyName = dto.CompanyName;
                claim.ContactPhoneNumber = dto.ContactPhoneNumber;
                claim.ContactAdverseLastNameOrBusinessName = dto.ContactAdverseLastNameOrBusinessName;
                claim.ContactAdverseFirstName = dto.ContactAdverseFirstName;
                claim.DayOfLoss = dto.DayOfLoss;
                claim.Deductible = dto.Deductible;
                claim.DescriptionOfLoss = dto.DescriptionOfLoss;
                claim.Email = dto.Email;
                claim.Extension = dto.Extension;
                claim.CreatedDate = DateTime.Now;
                claim.FaxNumber = dto.FaxNumber;
                claim.InsuredFirstName = dto.InsuredFirstName;
                claim.InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName;
                claim.InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner;
                claim.IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo;
                claim.IsReachAgreement = dto.IsReachAgreement;
                claim.LossType = dto.LossType;
                claim.Office = dto.Office;
                claim.PolicyNumber = dto.PolicyNumber;
                claim.SubmittedBy = dto.SubmittedBy;
                claim.UserId = userId;
                claim.VehicleMake = dto.VehicleMake;
                claim.VehicleModel = dto.VehicleModel;
                claim.VehicleNo = dto.VehicleNo;
                claim.VehicleOdometer = dto.VehicleOdometer;
                claim.VehicleOwnerFirstName = dto.VehicleOwnerFirstName;
                claim.VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName;
                claim.VehicleYear = dto.VehicleYear;
                claim.LiabilityPercent = dto.LiabilityPercent;
                claim.WorkPhone = dto.WorkPhone;
                claim.UpdatedDate = DateTime.Now;
                _context.SubrogationClaims.Update(claim);
            }
            await _context.SaveChangesAsync();
            return await Task.FromResult(claim);
        }

        public async Task<PropertyClaim> UpsertPropertyClaim(PropertyClaimDto dto, string userId)
        {
            var claim = _context.PropertyClaims.Where(x => x.Id == dto.Id).FirstOrDefault();
            if (claim == null)
            {
                claim = new PropertyClaim
                {
                    AceNo = dto.AceNo,
                    ClaimComments = dto.ClaimComments,
                    ClaimNo = dto.ClaimNo,
                    CompanyName = dto.CompanyName,
                    ContactPhoneNumber = dto.ContactPhoneNumber,
                    ContactShopName = dto.ContactShopName,
                    DayOfLoss = dto.DayOfLoss,
                    DescriptionOfLoss = dto.DescriptionOfLoss,
                    Email = dto.Email,
                    Extension = dto.Extension,
                    FaxNumber = dto.FaxNumber,
                    InsuredFirstName = dto.InsuredFirstName,
                    InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName,
                    InsuredSamePropertyOwner = dto.InsuredSamePropertyOwner,
                    IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo,
                    IsReachAgreement = dto.IsReachAgreement,
                    PolicyType = dto.PolicyType,
                    Office = dto.Office,
                    PolicyNumber = dto.PolicyNumber,
                    SubmittedBy = dto.SubmittedBy,
                    UserId = userId,
                    WorkPhone = dto.WorkPhone,
                    IsDelete = false,
                    PropertyOwnerFirstName = dto.PropertyOwnerFirstName,
                    PropertyOwnerLastNameOrBusinessName = dto.PropertyOwnerLastNameOrBusinessName,
                    PropertyOwnerState = dto.PropertyOwnerState,
                    PropertyOwnerZipCode = dto.PropertyOwnerZipCode,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };
                await _context.PropertyClaims.AddAsync(claim);
            }
            else
            {
                claim.AceNo = dto.AceNo;
                claim.ClaimComments = dto.ClaimComments;
                claim.ClaimNo = dto.ClaimNo;
                claim.CompanyName = dto.CompanyName;
                claim.ContactPhoneNumber = dto.ContactPhoneNumber;
                claim.ContactShopName = dto.ContactShopName;
                claim.DayOfLoss = dto.DayOfLoss;
                claim.DescriptionOfLoss = dto.DescriptionOfLoss;
                claim.Email = dto.Email;
                claim.Extension = dto.Extension;
                claim.CreatedDate = DateTime.Now;
                claim.FaxNumber = dto.FaxNumber;
                claim.InsuredFirstName = dto.InsuredFirstName;
                claim.InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName;
                claim.InsuredSamePropertyOwner = dto.InsuredSamePropertyOwner;
                claim.IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo;
                claim.IsReachAgreement = dto.IsReachAgreement;
                claim.PolicyType = dto.PolicyType;
                claim.Office = dto.Office;
                claim.PolicyNumber = dto.PolicyNumber;
                claim.SubmittedBy = dto.SubmittedBy;
                claim.UserId = userId;
                claim.WorkPhone = dto.WorkPhone;
                claim.PropertyOwnerFirstName = dto.PropertyOwnerFirstName;
                claim.PropertyOwnerLastNameOrBusinessName = dto.PropertyOwnerLastNameOrBusinessName;
                claim.PropertyOwnerState = dto.PropertyOwnerState;
                claim.PropertyOwnerZipCode = dto.PropertyOwnerZipCode;
                claim.UpdatedDate = DateTime.Now;
                _context.PropertyClaims.Update(claim);
            }
            await _context.SaveChangesAsync();
            return await Task.FromResult(claim);
        }

        public async Task<PhotoQuoteClaim> UpsertPhotoQuoteClaim(PhotoQuoteClaimDto dto, string userId)
        {
            var claim = _context.PhotoQuoteClaims.Where(x => x.Id == dto.Id).FirstOrDefault();
            if (claim == null)
            {
                claim = new PhotoQuoteClaim
                {
                    AceNo = dto.AceNo,
                    ClaimComments = dto.ClaimComments,
                    ClaimNo = dto.ClaimNo,
                    CompanyName = dto.CompanyName,
                    DayOfLoss = dto.DayOfLoss,
                    Deductible = dto.Deductible,
                    DescriptionOfLoss = dto.DescriptionOfLoss,
                    Email = dto.Email,
                    Extension = dto.Extension,
                    FaxNumber = dto.FaxNumber,
                    InsuredFirstName = dto.InsuredFirstName,
                    InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName,
                    InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner,
                    LossType = dto.LossType,
                    Office = dto.Office,
                    PolicyNumber = dto.PolicyNumber,
                    SubmittedBy = dto.SubmittedBy,
                    UserId = userId,
                    VehicleMake = dto.VehicleMake,
                    VehicleModel = dto.VehicleModel,
                    VehicleNo = dto.VehicleNo,
                    VehicleOwnerFirstName = dto.VehicleOwnerFirstName,
                    VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName,
                    VehicleYear = dto.VehicleYear,
                    WorkPhone = dto.WorkPhone,
                    IsReceiveSMS = dto.IsReceiveSMS,
                    VehicleOwnerZipCode = dto.VehicleOwnerZipCode,
                    VehiclePhoneNumber = dto.VehiclePhoneNumber,
                    IsDelete = false,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };
                await _context.PhotoQuoteClaims.AddAsync(claim);
            }
            else
            {
                claim.AceNo = dto.AceNo;
                claim.ClaimComments = dto.ClaimComments;
                claim.ClaimNo = dto.ClaimNo;
                claim.CompanyName = dto.CompanyName;
                claim.DayOfLoss = dto.DayOfLoss;
                claim.Deductible = dto.Deductible;
                claim.DescriptionOfLoss = dto.DescriptionOfLoss;
                claim.Email = dto.Email;
                claim.Extension = dto.Extension;
                claim.CreatedDate = DateTime.Now;
                claim.FaxNumber = dto.FaxNumber;
                claim.InsuredFirstName = dto.InsuredFirstName;
                claim.InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName;
                claim.InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner;
                claim.LossType = dto.LossType;
                claim.Office = dto.Office;
                claim.PolicyNumber = dto.PolicyNumber;
                claim.SubmittedBy = dto.SubmittedBy;
                claim.UserId = userId;
                claim.VehicleMake = dto.VehicleMake;
                claim.VehicleModel = dto.VehicleModel;
                claim.VehicleNo = dto.VehicleNo;
                claim.VehicleOwnerFirstName = dto.VehicleOwnerFirstName;
                claim.VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName;
                claim.VehicleYear = dto.VehicleYear;
                claim.WorkPhone = dto.WorkPhone;
                claim.IsReceiveSMS = dto.IsReceiveSMS;
                claim.VehicleOwnerZipCode = dto.VehicleOwnerZipCode;
                claim.VehiclePhoneNumber = dto.VehiclePhoneNumber;
                claim.UpdatedDate = DateTime.Now;
                _context.PhotoQuoteClaims.Update(claim);
            }
            await _context.SaveChangesAsync();
            return await Task.FromResult(claim);
        }

        public async Task<SpecialtyClaim> UpsertSpecialtyClaim(SpecialtyClaimDto dto, string userId)
        {
            var claim = _context.SpecialtyClaims.Where(x => x.Id == dto.Id).FirstOrDefault();
            if (claim == null)
            {
                claim = new SpecialtyClaim
                {
                    AceNo = dto.AceNo,
                    ClaimComments = dto.ClaimComments,
                    ClaimNo = dto.ClaimNo,
                    CompanyName = dto.CompanyName,
                    ContactPhoneNumber = dto.ContactPhoneNumber,
                    ContactShopName = dto.ContactShopName,
                    DayOfLoss = dto.DayOfLoss,
                    Deductible = dto.Deductible,
                    DescriptionOfLoss = dto.DescriptionOfLoss,
                    Email = dto.Email,
                    Extension = dto.Extension,
                    FaxNumber = dto.FaxNumber,
                    InsuredFirstName = dto.InsuredFirstName,
                    InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName,
                    InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner,
                    IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo,
                    IsReachAgreement = dto.IsReachAgreement,
                    LossType = dto.LossType,
                    Office = dto.Office,
                    PolicyNumber = dto.PolicyNumber,
                    SubmittedBy = dto.SubmittedBy,
                    UserId = userId,
                    VehicleMake = dto.VehicleMake,
                    VehicleModel = dto.VehicleModel,
                    VehicleNo = dto.VehicleNo,
                    VehicleOdometer = dto.VehicleOdometer,
                    VehicleOwnerFirstName = dto.VehicleOwnerFirstName,
                    VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName,
                    VehicleYear = dto.VehicleYear,
                    WorkPhone = dto.WorkPhone,
                    IsDelete = false,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };
                await _context.SpecialtyClaims.AddAsync(claim);
            }
            else
            {
                claim.AceNo = dto.AceNo;
                claim.ClaimComments = dto.ClaimComments;
                claim.ClaimNo = dto.ClaimNo;
                claim.CompanyName = dto.CompanyName;
                claim.ContactPhoneNumber = dto.ContactPhoneNumber;
                claim.ContactShopName = dto.ContactShopName;
                claim.DayOfLoss = dto.DayOfLoss;
                claim.Deductible = dto.Deductible;
                claim.DescriptionOfLoss = dto.DescriptionOfLoss;
                claim.Email = dto.Email;
                claim.Extension = dto.Extension;
                claim.CreatedDate = DateTime.Now;
                claim.FaxNumber = dto.FaxNumber;
                claim.InsuredFirstName = dto.InsuredFirstName;
                claim.InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName;
                claim.InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner;
                claim.IsPermittedGatherMoreInfo = dto.IsPermittedGatherMoreInfo;
                claim.IsReachAgreement = dto.IsReachAgreement;
                claim.LossType = dto.LossType;
                claim.Office = dto.Office;
                claim.PolicyNumber = dto.PolicyNumber;
                claim.SubmittedBy = dto.SubmittedBy;
                claim.UserId = userId;
                claim.VehicleMake = dto.VehicleMake;
                claim.VehicleModel = dto.VehicleModel;
                claim.VehicleNo = dto.VehicleNo;
                claim.VehicleOdometer = dto.VehicleOdometer;
                claim.VehicleOwnerFirstName = dto.VehicleOwnerFirstName;
                claim.VehicleOwnerLastNameOrBusinessName = dto.VehicleOwnerLastNameOrBusinessName;
                claim.VehicleYear = dto.VehicleYear;
                claim.WorkPhone = dto.WorkPhone;
                claim.UpdatedDate = DateTime.Now;
                _context.SpecialtyClaims.Update(claim);
            }
            await _context.SaveChangesAsync();
            return await Task.FromResult(claim);
        }

        public async Task<TotalLossClaim> UpsertTotalLossClaim(TotalLossClaimDto dto, string userId)
        {
            var claim = _context.TotalLossClaims.Where(x => x.Id == dto.Id).FirstOrDefault();
            if (claim == null)
            {
                claim = new TotalLossClaim
                {
                    AceNo = dto.AceNo,
                    ClaimComments = dto.ClaimComments,
                    ClaimNo = dto.ClaimNo,
                    CompanyName = dto.CompanyName,
                    DayOfLoss = dto.DayOfLoss,
                    Deductible = dto.Deductible,
                    Email = dto.Email,
                    Extension = dto.Extension,
                    FaxNumber = dto.FaxNumber,
                    InsuredFirstName = dto.InsuredFirstName,
                    InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName,
                    InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner,
                    Office = dto.Office,
                    SubmittedBy = dto.SubmittedBy,
                    UserId = userId,
                    VehicleMake = dto.VehicleMake,
                    VehicleModel = dto.VehicleModel,
                    VehicleNo = dto.VehicleNo,
                    VehicleOdometer = dto.VehicleOdometer,
                    VehicleYear = dto.VehicleYear,
                    VehicleState = dto.VehicleState,
                    WorkPhone = dto.WorkPhone,
                    ClaimantLastNameOrBusinessName = dto.ClaimantLastNameOrBusinessName,
                    ClaimantOwnerFirstName = dto.ClaimantOwnerFirstName,

                    Conveniences = dto.Conveniences != null ? string.Join(",",dto.Conveniences) : null,
                    Decors = dto.Decors != null ? string.Join(",", dto.Decors) : null,
                    Motorcycles = dto.Motorcycles != null ? string.Join(",", dto.Motorcycles) : null,
                    Paints = dto.Paints != null ? string.Join(",", dto.Paints) : null,
                    PowerOptions = dto.PowerOptions != null ? string.Join(",", dto.PowerOptions) : null,
                    Radios = dto.Radios != null ? string.Join(",", dto.Radios) : null,
                    Roofs = dto.Roofs != null ? string.Join(",", dto.Roofs) : null,
                    Safetys = dto.Safetys != null ? string.Join(",", dto.Safetys) : null,
                    Seats = dto.Seats != null ? string.Join(",", dto.Seats) : null,
                    Trucks = dto.Trucks != null ? string.Join(",", dto.Trucks) : null,
                    Wheels = dto.Wheels != null ? string.Join(",", dto.Wheels) : null,

                    IsDelete = false,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };
                await _context.TotalLossClaims.AddAsync(claim);
            }
            else
            {
                claim.AceNo = dto.AceNo;
                claim.ClaimComments = dto.ClaimComments;
                claim.ClaimNo = dto.ClaimNo;
                claim.CompanyName = dto.CompanyName;
                claim.DayOfLoss = dto.DayOfLoss;
                claim.Deductible = dto.Deductible;
                claim.Email = dto.Email;
                claim.Extension = dto.Extension;
                claim.CreatedDate = DateTime.Now;
                claim.FaxNumber = dto.FaxNumber;
                claim.InsuredFirstName = dto.InsuredFirstName;
                claim.InsuredLastNameOrBusinessName = dto.InsuredLastNameOrBusinessName;
                claim.InsuredSameVehicleOwner = dto.InsuredSameVehicleOwner;
                claim.Office = dto.Office;
                claim.SubmittedBy = dto.SubmittedBy;
                claim.UserId = userId;
                claim.VehicleMake = dto.VehicleMake;
                claim.VehicleModel = dto.VehicleModel;
                claim.VehicleNo = dto.VehicleNo;
                claim.VehicleOdometer = dto.VehicleOdometer;
                claim.VehicleYear = dto.VehicleYear;
                claim.VehicleState = dto.VehicleState;
                claim.WorkPhone = dto.WorkPhone;

                claim.ClaimantLastNameOrBusinessName = dto.ClaimantLastNameOrBusinessName;
                claim.ClaimantOwnerFirstName = dto.ClaimantOwnerFirstName;

                claim.ClaimantLastNameOrBusinessName = dto.ClaimantLastNameOrBusinessName;
                claim.ClaimantOwnerFirstName = dto.ClaimantOwnerFirstName;

                claim.Conveniences = dto.Conveniences != null ? string.Join(",", dto.Conveniences) : null;
                claim.Decors = dto.Decors != null ? string.Join(",", dto.Decors) : null;
                claim.Motorcycles = dto.Motorcycles != null ? string.Join(",", dto.Motorcycles) : null;
                claim.Paints = dto.Paints != null ? string.Join(",", dto.Paints) : null;
                claim.PowerOptions = dto.PowerOptions != null ? string.Join(",", dto.PowerOptions) : null;
                claim.Radios = dto.Radios != null ? string.Join(",", dto.Radios) : null;
                claim.Roofs = dto.Roofs != null ? string.Join(",", dto.Roofs) : null;
                claim.Safetys = dto.Safetys != null ? string.Join(",", dto.Safetys) : null;
                claim.Seats = dto.Seats != null ? string.Join(",", dto.Seats) : null;
                claim.Trucks = dto.Trucks != null ? string.Join(",", dto.Trucks) : null;
                claim.Wheels = dto.Wheels != null ? string.Join(",", dto.Wheels) : null;


                claim.UpdatedDate = DateTime.Now;
                _context.TotalLossClaims.Update(claim);
            }
            await _context.SaveChangesAsync();
            return await Task.FromResult(claim);
        }

        public void Dispose()
        {

        }

        public async Task InsertAttachedImage(AttachedImage dto)
        {
            _context.AttachedImages.Add(dto);
            await _context.SaveChangesAsync();
        }
    }
}
