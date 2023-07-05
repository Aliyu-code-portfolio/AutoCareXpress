using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Creation
{
    public record ServiceProviderCreationDto
    {
        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(50, ErrorMessage = "Company name must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyName { get; init; }

        [Required(ErrorMessage = "Company email is required.")]
        [EmailAddress(ErrorMessage = "Invalid company email format.")]
        [StringLength(50, ErrorMessage = "Company email must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyEmail { get; init; }

        [Required(ErrorMessage = "Company phone number is required.")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Phone must be a 11-digit number.")]
        public string? CompanyPhone { get; init; }


        [StringLength(50, ErrorMessage = "Registration number must be between 1 and 50 characters.")]
        public string? RegistrationNumber { get; init; }

        [Range(0, 5, ErrorMessage = "Rating must be in the range 0 - 5")]
        public int? OverallServiceRating { get; set; }

        [ForeignKey(nameof(Ref_Service_Location))]
        public int Ref_Service_Location_Id { get; init; }
    }
}
