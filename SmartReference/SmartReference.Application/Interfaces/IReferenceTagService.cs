using System.Collections.Generic;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Interfaces
{
    public interface IReferenceTagService
    {
        public ReferenceTag Create(Reference reference, Tag tag);
        public IEnumerable<ReferenceTag> CreateForReference(Reference reference, IEnumerable<Tag> tags);
    }
}