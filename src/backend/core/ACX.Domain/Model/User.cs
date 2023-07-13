using ACX.Domain.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class User : IdentityUser
    {
        
        [StringLength(25, ErrorMessage = "Name must be between 1 and 25 characters.", MinimumLength = 1)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(50, ErrorMessage = "Email must be between 1 and 50 characters.", MinimumLength = 1)]
        public override string? Email { get; set; }

        [RegularExpression("^[MF]$", ErrorMessage = "Gender must be either 'M' or 'F'.")]
        public char? Gender { get; set; }
        public int? EmailVerifyCode { get; set; }
        public string? PasswordResetCode { get; set; }
        public DateTime? EmailVerifyDate { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }
        public DateTime? EmailTokenExpiryDate { get; set; } = null;
        public DateTime? PasswordChangeTokenExpiryDate { get; set; } = null;//
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        //Navigational properties
        public virtual ICollection<Appointment>? Appointments { get; set; }  
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
        //public virtual PickUpAddress? PickUpAddresses { get; set; }
    }
}
