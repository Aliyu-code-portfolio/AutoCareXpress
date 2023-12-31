﻿using ACX.Application.DTOs.Creation;
using ACX.EndsPoint.ActionFilters;
using ACX.ServiceContract.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.EndsPoint.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/verification")]
    [ApiController]
    public class VerificationController : ControllerBase
    {
        private readonly IServiceManager _service;
        public VerificationController(IServiceManager service) => _service = service;

        //Send email verification to user email address
        [HttpPost("verify/request/{id}")]
        public async Task<ActionResult> RequestVerifyEmail(string id)
        {
            await _service.AuthenticationService.SendVerifyCodeToEmail(id);
            return Ok("Email sent. Please verify");

        }

        //Verification token
        [HttpPost("verify/email/{id}/{payload}")]
        public async Task<ActionResult> VerifyEmail(string id, int payload)
        {
            await _service.AuthenticationService.VerifyEmail(id, payload);
            return Ok("Successfully verified. Login");

        }

        ///
        //Verification token
        [HttpPost("verify/forget/{id}/{payload}/{password}")]
        [ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> VerifyForgot(string id, int payload, string password)
        {
            await _service.AuthenticationService.VerifyPasswordForgot(id, payload, password);
            return Ok("Successfully changed password");

        }

        //Verification token
        [HttpPost("forgot/{id}")]
        [ServiceFilter(typeof(ValidationActionFilter))]
        public async Task<ActionResult> ForgetPassword(string id)
        {
            await _service.AuthenticationService.SendPasswordResetCode(id);
            return Ok("Check email and verify");

        }

    }
}
