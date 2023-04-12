using AceApp.Data;
using AceApp.Models;

namespace AceApp.Services
{
    public interface IClaimsService : IDisposable
    {
        Task<AutoClaim> UpsertAutoClaim(AutoClaimDto dto, string userId);
        Task<PropertyClaim> UpsertPropertyClaim(PropertyClaimDto dto, string userId);
        Task<PhotoQuoteClaim> UpsertPhotoQuoteClaim(PhotoQuoteClaimDto dto, string userId);
        Task<SpecialtyClaim> UpsertSpecialtyClaim(SpecialtyClaimDto dto, string userId);
        Task<SubrogationClaim> UpsertSubrogationClaim(SubrogationClaimDto dto, string userId);
        Task<TotalLossClaim> UpsertTotalLossClaim(TotalLossClaimDto dto, string userId);
        Task InsertAttachedImage(AttachedImage dto);
    }
}
