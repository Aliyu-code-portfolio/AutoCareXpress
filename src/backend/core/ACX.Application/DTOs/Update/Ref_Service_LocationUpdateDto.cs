using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Update
{
    public record Ref_Service_LocationUpdateDto
    {
        public int Id { get; init; }
        [Required(ErrorMessage = "Service Location is required")]
        [StringLength(25, ErrorMessage = "Service Location must be at most 25 characters")]
        public string? Location { get; init; }
    }
}
