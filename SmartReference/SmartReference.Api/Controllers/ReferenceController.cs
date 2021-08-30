using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartReference.Application.Interfaces;
using SmartReference.Application.Parameters;
using SmartReference.Domain.Models;

namespace SmartReference.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReferenceController : ControllerBase
    {
        private readonly IReferenceService _referenceService;

        public ReferenceController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<string> Create(CreateReferenceParameters parameters)
        {
            return Created("wowowow", "lol");
        }

        [HttpGet]
        [ProducesResponseType(typeof(Reference[]), (int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<Reference>> List()
        {
            return Ok(_referenceService.List());
        }
    }
}