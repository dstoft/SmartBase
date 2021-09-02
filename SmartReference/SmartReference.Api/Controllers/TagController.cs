using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using SmartReference.Application.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Tag[]), (int)HttpStatusCode.OK)]
        public ActionResult<IEnumerable<Tag>> List()
        {
            return Ok(_tagService.List());
        }
    }
}