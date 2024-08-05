﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace OrderAPI.Controllers
{
    /// <summary>
    /// Controller responsible for handling errors and returning error responses.
    /// </summary>
    [ApiController]
    [Route("error")]
    public class ErrorController : ControllerBase
    {
        /// <summary>
        /// Handles error requests and returns a custom error response.
        /// </summary>
        /// <returns>A custom error response.</returns>
        [HttpGet("")]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error;

            return Problem(
                detail: exception.Message,
                title: "An error occurred",
                statusCode: 500
            );
        }
    }
}