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
    public record ServiceProviderDisplayDto
    {
        public Guid Id { get; set; }
        public string? CompanyName { get; set; }

        public string? CompanyEmail { get; set; }

        public int CompanyPhone { get; set; }

        public string? RegistrationNumber { get; set; }

        [ForeignKey(nameof(Ref_Service_Location))]
        public int Ref_Service_Location_Id { get; set; }
    }
}
