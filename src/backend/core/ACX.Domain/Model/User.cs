using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ACX.Domain.Model
{
    public class User : AuditableBaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(25, ErrorMessage = "Name must be between 1 and 25 characters.", MinimumLength = 1)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(50, ErrorMessage = "Email must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone must be a 10-digit number.")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [RegularExpression("^[MF]$", ErrorMessage = "Gender must be either 'M' or 'F'.")]
        public char Gender { get; set; }
    }
}
