using System.ComponentModel.DataAnnotations;

namespace AceApp.Models
{
    public class AttachedImage
    {
        public long Id { get; set; }
        public long ClaimId { get; set; }
        public string ImageSrc { get; set; }
        public int ClaimType { get; set; }

    }
}
