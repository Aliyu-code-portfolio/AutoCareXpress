using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Display
{
    public record AppointmentDisplayDto
    {
        public int Id { get; init; }

        [ForeignKey(nameof(ServiceProvider))]
        public Guid ServiceProviderId { get; init; }

        [ForeignKey(nameof(ProviderService))]
        public Guid ProviderServiceId { get; init; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; init; }

        [ForeignKey(nameof(Ref_Service_Type))]
        public Guid Ref_Service_Type_Id { get; init; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; init; }
    }
}
