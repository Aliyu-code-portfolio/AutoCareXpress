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
    public record AppointmentCreationDto
    {
        [Required(ErrorMessage ="ServiceProvider ID is required")]
        public string? ServiceProviderId { get; init; }

        [Required(ErrorMessage = "ProviderService ID is required")]
        public int ProviderServiceId { get; init; }

        [Required(ErrorMessage = "User ID is required")]
        public string? UserId { get; init; }
        [Required(ErrorMessage = "Service Type ID is required")]
        public int Ref_Service_Type_Id { get; init; }
        [StringLength(int.MaxValue)]
        public string? Description { get; set; }


    }
}
