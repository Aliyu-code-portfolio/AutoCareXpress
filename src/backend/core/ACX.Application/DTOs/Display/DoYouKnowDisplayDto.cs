using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Display
{
    public record DoYouKnowDisplayDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
