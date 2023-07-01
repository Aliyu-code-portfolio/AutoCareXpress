using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Update
{
    public record Ref_Service_TypeUpdateDto
    {
        public int Id { get; init; }
        [Required(ErrorMessage = "Service Name is required")]
        [StringLength(25, ErrorMessage = "Service Name must be at most 25 characters")]
        public string? ServiceName { get; init; }
        [Required(ErrorMessage = "Service Description is required")]
        [StringLength(100, ErrorMessage = "Service Description must be at most 100 characters")]
        public string? Description { get; init; }
    }
}
