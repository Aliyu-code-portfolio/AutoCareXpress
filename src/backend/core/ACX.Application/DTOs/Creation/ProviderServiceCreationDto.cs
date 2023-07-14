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
    public record ProviderServiceCreationDto
    {
        [Required(ErrorMessage ="Service Type ID is required")]
        public int Ref_Service_Type_ID { get; init; }
        [Required(ErrorMessage = "Provider ID is required")]
        public Guid ServiceProviderId { get; init; }

        [Range(0, double.MaxValue, ErrorMessage = "Minimum price must be a non-negative number.")]
        [Required(ErrorMessage = "Minimum Price is required")]
        public decimal MinPrice { get; init; }
    }
}
