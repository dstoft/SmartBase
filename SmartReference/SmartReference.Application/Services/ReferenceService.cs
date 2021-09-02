using System.Collections.Generic;
using System.Linq;
using SmartReference.Application.Interfaces;
using SmartReference.Application.Parameters;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Services
{
    public class ReferenceService : IReferenceService
    {
        private readonly IReferenceTagService _referenceTagService;
        private readonly IReferenceRepository _repository;
        private readonly ITagService _tagService;

        public ReferenceService(IReferenceRepository repository, ITagService tagService,
            IReferenceTagService referenceTagService)
        {
            _repository = repository;
            _tagService = tagService;
            _referenceTagService = referenceTagService;
        }

        public Reference Create(CreateReferenceParameters parameters)
        {
            var reference = new Reference(parameters.Name, parameters.Link, parameters.Abstract, parameters.Citation);
            _repository.Create(reference);

            var tagList = parameters.Tags
                .Select(tagName => _tagService.Create(new CreateTagParameters { Name = tagName })).ToList();
            _referenceTagService.CreateForReference(reference, tagList);
            return reference;
        }

        public IEnumerable<Reference> List()
        {
            return _repository.List();
        }

        public IEnumerable<Reference> ListOnTag(ListReferencesOnTag parameters)
        {
            var tag = _tagService.Get(parameters.TagName);
            return _repository.GetOnReferenceTagTag(tag);
        }
    }
}