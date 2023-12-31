﻿using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Creation
{
    public record VehicleCreationDto
    {
        [Required(ErrorMessage = "User ID is required")]
        public string? UserId { get; init; }

        [Required(ErrorMessage = "Color is required")]
        [StringLength(20, ErrorMessage = "Color must be at most 20 characters")]
        public string? Color { get; init; }

        [Required(ErrorMessage = "PlateNumber is required")]
        [StringLength(10, ErrorMessage = "PlateNumber must be at most 10 alphanumeric Characters")]
        public string? PlateNumber { get; init; }

        [Required(ErrorMessage = "Manufacture name is required")]
        [StringLength(25, ErrorMessage = "Manufacture name must be at most 25 characters")]
        public string? Manufacture { get; init; }

        [Required(ErrorMessage = "Model name is required")]
        [StringLength(25, ErrorMessage = "Model name must be at most 25 characters")]
        public string? Model { get; init; }
    }
}
