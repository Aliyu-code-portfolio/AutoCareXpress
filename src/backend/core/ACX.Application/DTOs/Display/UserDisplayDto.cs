using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Display
{
    public record UserDisplayDto
    {
        public string? Id { get; init; }
        public string? Name { get; init; }

        public string? Email { get; init; }

        public string? PhoneNumber { get; init; }

        public char? Gender { get; init; }
    }
}
