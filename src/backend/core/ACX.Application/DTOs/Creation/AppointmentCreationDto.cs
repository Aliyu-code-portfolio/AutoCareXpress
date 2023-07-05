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
        public Guid ServiceProviderId { get; init; }

        [Required(ErrorMessage = "ProviderService ID is required")]
        public Guid ProviderServiceId { get; init; }

        [Required(ErrorMessage = "User ID is required")]
        public Guid UserId { get; init; }

        public int Ref_Service_Type_Id { get; init; }
        [StringLength(int.MaxValue)]
        public string? Description { get; set; }
        [Range(0, 5, ErrorMessage = "Rating must be in the range 0 - 5")]
        public int? RateService { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; init; }

    }
}
