using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Update
{
    public record ServiceProviderUpdateDto
    {
        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(50, ErrorMessage = "Company name must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyName { get; init; }


        [Required(ErrorMessage = "Company phone number is required.")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Company phone number must be a 10-digit number.")]
        public int CompanyPhone { get; init; }

        [ForeignKey(nameof(Ref_Service_Location))]
        public int Ref_Service_Location_Id { get; init; }
    }
}
