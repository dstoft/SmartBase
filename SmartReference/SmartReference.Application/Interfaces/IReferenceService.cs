using System.Collections.Generic;
using SmartReference.Application.Parameters;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Interfaces
{
    public interface IReferenceService
    {
        public Reference Create(CreateReferenceParameters parameters);
        public IEnumerable<Reference> List();
        public IEnumerable<Reference> ListOnTag(ListReferencesOnTag parameters);
    }
}