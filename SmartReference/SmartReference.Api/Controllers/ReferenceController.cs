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
            var created = _referenceService.Create(parameters);
            return Created(created.Name, created);
        }

        [HttpGet]
        [ProducesResponseType(typeof(Reference[]), (int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<Reference>> List()
        {
            return Ok(_referenceService.List());
        }

        [HttpGet("tag/{tagName}")]
        [ProducesResponseType(typeof(Reference[]), (int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<Reference>> ListOnTag(string tagName)
        {
            return Ok(_referenceService.ListOnTag(new ListReferencesOnTag { TagName = tagName }));
        }
    }
}