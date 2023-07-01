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
        public string? CompanyName { get; init; }

        public string? CompanyEmail { get; init; }

        public int CompanyPhone { get; init; }

        public string? RegistrationNumber { get; init; }

        [ForeignKey(nameof(Ref_Service_Location))]
        public int Ref_Service_Location_Id { get; init; }
    }
}
