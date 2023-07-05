using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Update
{
    public record UserUpdateDto
    {
        public Guid Id { get; init; }
        [StringLength(25, ErrorMessage = "Name must be between 1 and 25 characters.", MinimumLength = 1)]
        public string? Name { get; init; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(50, ErrorMessage = "Email must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? Email { get; set; }

        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Phone must be a 11-digit number.")]
        public string? Phone { get; init; }

        [Required(ErrorMessage = "Gender is required.")]
        [RegularExpression("^[MF]$", ErrorMessage = "Gender must be either 'M' or 'F'.")]
        public char? Gender { get; init; }
    }
}
