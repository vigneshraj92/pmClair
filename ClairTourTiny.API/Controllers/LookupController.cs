﻿using ClairTourTiny.Core.Interfaces;
using ClairTourTiny.Core.Models.Lookup;
using Microsoft.AspNetCore.Mvc;


//test
namespace ClairTourTiny.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class LookupController(ILookupService service) : ControllerBase
    {
        private ILookupService _service = service;

        [HttpGet("exchange-rates")]
        [ProducesResponseType(typeof(List<ExchangeRateModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetExchangeRates() => Ok(_service.GetExchangeRates());
    }
}
