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
        [StringLength(25, ErrorMessage = "Name must be between 1 and 25 characters.", MinimumLength = 1)]
        public string? Name { get; init; }

        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone must be a 10-digit number.")]
        public int? Phone { get; init; }

        [Required(ErrorMessage = "Gender is required.")]
        [RegularExpression("^[MF]$", ErrorMessage = "Gender must be either 'M' or 'F'.")]
        public char? Gender { get; init; }
    }
}
