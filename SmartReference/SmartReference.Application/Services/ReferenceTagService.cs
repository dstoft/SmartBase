using System;
using System.Collections.Generic;
using System.Linq;
using SmartReference.Application.Interfaces;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Services
{
    public class ReferenceTagService : IReferenceTagService
    {
        private readonly IReferenceTagRepository _referenceTagRepository;

        public ReferenceTagService(IReferenceTagRepository referenceTagRepository)
        {
            _referenceTagRepository = referenceTagRepository;
        }

        public ReferenceTag Create(Reference reference, Tag tag)
        {
            var referenceTag = new ReferenceTag(Guid.NewGuid(), reference.Name, tag.Name);
            _referenceTagRepository.Create(referenceTag);
            return referenceTag;
        }

        public IEnumerable<ReferenceTag> CreateForReference(Reference reference, IEnumerable<Tag> tags)
        {
            return tags.Select(tag => Create(reference, tag));
        }
    }
}