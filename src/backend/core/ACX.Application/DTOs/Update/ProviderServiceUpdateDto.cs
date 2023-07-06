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
    public record ProviderServiceUpdateDto
    {
        [Required(ErrorMessage = "ID is required")]
        public int Id { get; init; }

        [Required(ErrorMessage = "Service Type ID is required")]
        public int Ref_Service_Type_ID { get; init; }

        [Required(ErrorMessage = "Minumum price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Minimum price must be a non-negative number.")]
        public decimal MinPrice { get; init; }
    }
}
