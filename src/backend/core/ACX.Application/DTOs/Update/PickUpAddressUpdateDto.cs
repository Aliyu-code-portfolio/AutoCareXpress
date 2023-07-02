using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Update
{
    public record PickUpAddressUpdateDto
    {
        public Guid Guid { get; init; }

        [Required(ErrorMessage = "BuildingNumber is required")]
        [StringLength(5, ErrorMessage = "BuildingNumber must be at most 10 characters")]
        public string? BuildingNumber { get; init; }

        [Required(ErrorMessage = "StreetName is required")]
        [StringLength(50, ErrorMessage = "StreetName must be at most 50 characters")]
        public string? StreetName { get; init; }

        [Required(ErrorMessage = "Locality  Description is required")]
        [StringLength(50, ErrorMessage = "Locality must be at most 50 characters")]
        public string? Locality { get; init; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(50, ErrorMessage = "State must be at most 50 characters")]
        public string? State { get; init; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(50, ErrorMessage = "Country must be at most 50 characters")]
        public string? Country { get; init; }
    }
}
