﻿using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Update
{
    public record ServiceProviderUpdateDto
    {
        [Required(ErrorMessage = "ID is required")]
        public string Id { get; init; }
        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(50, ErrorMessage = "Company name must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyName { get; init; }


        [Required(ErrorMessage = "Company phone number is required.")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Company phone number must be a 11-digit number.")]
        public string? CompanyPhone { get; init; }

        [Required(ErrorMessage = "Service Location ID is required")]
        [ForeignKey(nameof(Ref_Service_Location))]
        public int Ref_Service_Location_Id { get; init; }
/*
        [Required(ErrorMessage = "The status is required")]
        public bool IsAvailable { get; init; }*/
    }
}
