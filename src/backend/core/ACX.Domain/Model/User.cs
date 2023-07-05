using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class User : AuditableBaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        //[Required(ErrorMessage = "Name is required.")]
        [StringLength(25, ErrorMessage = "Name must be between 1 and 25 characters.", MinimumLength = 1)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(50, ErrorMessage = "Email must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? Email { get; set; }

        //[Required(ErrorMessage = "Phone is required.")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Phone must be a 11-digit number.")]
        public string? Phone { get; set; }

        //[Required(ErrorMessage = "Gender is required.")]
        [RegularExpression("^[MF]$", ErrorMessage = "Gender must be either 'M' or 'F'.")]
        public char? Gender { get; set; }

        //Navigational properties
        public virtual ICollection<Appointment>? Appointments { get; set; }  
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
        public virtual PickUpAddress? PickUpAddresses { get; set; }
    }
}
