using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Display
{
    public record Ref_Service_Location_Display_Dto
    {
        public int Id { get; set; }

        public string? Location { get; set; }

    }
}
