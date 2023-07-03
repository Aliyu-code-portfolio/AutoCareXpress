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

        public Guid ServiceProviderId { get; init; }

        public Guid ProviderServiceId { get; init; }

        public Guid UserId { get; init; }

        public Guid Ref_Service_Type_Id { get; init; }
        [StringLength(int.MaxValue)]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; init; }

    }
}
