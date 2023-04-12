using System;
using System.Collections.Generic;

namespace AceApp.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            UserDetail = new HashSet<UserDetail>();
            AutoClaims = new HashSet<AutoClaim>();
            PropertyClaims = new HashSet<PropertyClaim>();
            PhotoQuoteClaims = new HashSet<PhotoQuoteClaim>();
            SpecialtyClaims = new HashSet<SpecialtyClaim>();
            SubrogationClaims = new HashSet<SubrogationClaim>();
            TotalLossClaims = new HashSet<TotalLossClaim>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual ICollection<UserDetail> UserDetail { get; set; }
        public virtual ICollection<AutoClaim> AutoClaims { get; set; }
        public virtual ICollection<PropertyClaim> PropertyClaims { get; set; }
        public virtual ICollection<PhotoQuoteClaim> PhotoQuoteClaims { get; set; }
        public virtual ICollection<SpecialtyClaim> SpecialtyClaims { get; set; }
        public virtual ICollection<SubrogationClaim> SubrogationClaims { get; set; }
        public virtual ICollection<TotalLossClaim> TotalLossClaims { get; set; }
    }
}
