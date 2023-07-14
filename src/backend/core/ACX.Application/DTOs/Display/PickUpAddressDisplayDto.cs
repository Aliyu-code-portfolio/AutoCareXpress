using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Display
{
    public record PickUpAddressDisplayDto
    {
        public Guid userId { get; init; }

        public string? BuildingNumber { get; init; }

        public string? StreetName { get; init; }

        public string? Locality { get; init; }

        public string? State { get; init; }

        public string? Country { get; init; }
    }
}
