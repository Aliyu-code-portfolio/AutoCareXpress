using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class ServiceProvider:AuditableBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(50, ErrorMessage = "Company name must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyName { get; set; }

        [Required(ErrorMessage = "Company email is required.")]
        [EmailAddress(ErrorMessage = "Invalid company email format.")]
        [StringLength(50, ErrorMessage = "Company email must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyEmail { get; set; }

        [Required(ErrorMessage = "Company phone number is required.")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Phone must be a 11-digit number.")]
        public string? CompanyPhone { get; init; }


        [StringLength(50, ErrorMessage = "Registration number must be between 1 and 50 characters.")]
        public string? RegistrationNumber { get; set; }

        [Range(0, 5, ErrorMessage = "Service Rating must be in the range 0 - 5")]
        public int? OverallServiceRating { get; set; }

        [ForeignKey(nameof(Ref_Service_Location))]
        public int Ref_Service_Location_Id { get; set; }

        //Navigational properties
        public virtual ICollection<Appointment>? Appointments { get; set; }
        public virtual ICollection<ProviderService>? ProviderServices { get; set; }
    }
}
