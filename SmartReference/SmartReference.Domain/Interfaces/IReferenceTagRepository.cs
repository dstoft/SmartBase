using System;
using SmartReference.Domain.Models;

namespace SmartReference.Domain.Interfaces
{
    public interface IReferenceTagRepository
    {
        public Guid Create(ReferenceTag referenceTag);
    }
}