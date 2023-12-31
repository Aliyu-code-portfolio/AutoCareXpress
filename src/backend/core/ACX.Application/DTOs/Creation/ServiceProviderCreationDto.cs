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
    public record ServiceProviderCreationDto
    {
        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(50, ErrorMessage = "Company name must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyName { get; init; }


        [Required(ErrorMessage = "Company phone number is required.")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Phone must be a 11-digit number.")]
        public string? CompanyPhone { get; init; }

        [Required(ErrorMessage = "Registration number is required")]
        [StringLength(50, ErrorMessage = "Registration number must be between 1 and 50 characters.")]
        public string? RegistrationNumber { get; init; }

        [Required(ErrorMessage = "Service Location ID is required")]
        public int Ref_Service_Location_Id { get; init; }

        [Required(ErrorMessage = "Company email is required.")]
        [EmailAddress(ErrorMessage = "Invalid company email format.")]
        [StringLength(50, ErrorMessage = "Company email must be between 1 and 50 characters.", MinimumLength = 1)]
        public string? CompanyEmail { get; init; }

        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; init; }
        [Required(ErrorMessage ="The role is required")]
        public ICollection<string>? Roles
        {
            get; init;
        }
    }
}
