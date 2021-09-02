using System.Collections.Generic;
using SmartReference.Domain.Models;

namespace SmartReference.Domain.Interfaces
{
    public interface IReferenceRepository
    {
        public string Create(Reference reference);
        public IEnumerable<Reference> List();
        public Reference Get(string name);
        public IEnumerable<Reference> GetOnReferenceTagTag(Tag tag);
    }
}