using System.Collections.Generic;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Interfaces
{
    public interface IReferenceService
    {
        public string Create(Reference reference);
        public IEnumerable<Reference> List();
    }
}