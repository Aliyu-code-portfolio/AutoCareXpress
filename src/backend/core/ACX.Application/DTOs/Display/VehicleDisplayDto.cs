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
    public record VehicleDisplayDto
    {
        public int Id { get; init; }

        public Guid UserId { get; init; }

        public string? Color { get; init; }

        public string? PlateNumber { get; init; }

        public string? Manufacture { get; init; }

        public string? Model { get; init; }

    }
}
