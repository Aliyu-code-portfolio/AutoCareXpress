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

        public string? ServiceProviderId { get; init; }//use to pull from db

        public int ProviderServiceId { get; init; }

        public string? UserId { get; init; }

        public int Ref_Service_Type_Id { get; init; }
        public bool Status { get; set; } = false;
        public string? Description { get; set; }
        public int? RateService { get; set; } = null;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; init; } = null;
        public ServiceProviderDisplayDto? ServiceProviderDisplayDto { get; set; }
        public Ref_Service_Type_Display_Dto? Ref_Service_Type_Display_Dto { get; set; }
    }
}
