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
    public record ProviderServiceDisplayDto
    {
        public int Id { get; init; }


        public string ServiceProviderId { get; init; }//use the id to pull data and place into the individual dto
        public int Ref_Service_Type_ID { get; init; }//use the id to pull data and place into the individual dto

        public decimal MinPrice { get; init; }
        public ServiceProviderDisplayDto? ServiceProviderDisplayDto { get; set; }
        public Ref_Service_Type_Display_Dto? Ref_Service_Type_Display_Dto { get; set; }
    }
}
