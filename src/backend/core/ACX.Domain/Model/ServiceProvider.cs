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


        //Aliyu please review. I added email and phone number to the service providers. It wasn't included in the model diagram.

        [Required(ErrorMessage = "Company email is required.")]
        [EmailAddress(ErrorMessage = "Invalid company email format.")]
        [StringLength(50, ErrorMessage = "Company email must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyEmail { get; set; }

        [Required(ErrorMessage = "Company phone number is required.")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Company phone number must be a 10-digit number.")]
        public int CompanyPhone { get; set; }


        [StringLength(50, ErrorMessage = "Registration number must be between 1 and 50 characters.")]
        public string? RegistrationNumber { get; set; }

        [ForeignKey(nameof(Ref_Service_Location))]
        public Guid Ref_Service_Location_Id { get; set; }
    }
}
