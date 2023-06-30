using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ACX.Domain.Model
{
    public class PickUpAddress:AuditableBaseEntity
    {
        [Key]
        public Guid Guid { get; set; }

        [Required(ErrorMessage = "BuildingNumber is required")]
        [StringLength(5, ErrorMessage = "BuildingNumber must be at most 10 characters")]
        public string? BuildingNumber { get; set; }

        [Required(ErrorMessage = "StreetName is required")]
        [StringLength(50, ErrorMessage = "StreetName must be at most 50 characters")]
        public string? StreetName { get; set; }

        [Required(ErrorMessage = "Locality  Description is required")]
        [StringLength(50, ErrorMessage = "Locality must be at most 50 characters")]
        public string? Locality { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(50, ErrorMessage = "State must be at most 50 characters")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(50, ErrorMessage = "Country must be at most 50 characters")]
        public string? Country { get; set; } 
     // public double Latitude { get; set; }
     // public double Longitude { get; set; }

    }
}       

