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
    public record AppointmentUpdateDto
    {
        [Required(ErrorMessage = "ID is required")]
        public int Id { get; init; }

        [Required(ErrorMessage = "Service Provider ID is required")]
        public string? ServiceProviderId { get; init; }

        [Required(ErrorMessage = "Provider Service ID is required")]
        public int? ProviderServiceId { get; init; }

        [Required(ErrorMessage = "Service Type ID is required")]
        public string? Ref_Service_Type_Id { get; init; }
        [StringLength(int.MaxValue)]

        public string? Description { get; set; }
        [Range(0, 5, ErrorMessage = "Rating must be in the range 0 - 5")]
        public int? RateService { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; init; }

        public bool Status { get; init; } = false;
    }
}
