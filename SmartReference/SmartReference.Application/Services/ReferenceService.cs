using System;
using System.Collections.Generic;
using SmartReference.Application.Interfaces;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Services
{
    public class ReferenceService : IReferenceService
    {
        private IReferenceRepository _repository;

        public ReferenceService(IReferenceRepository repository)
        {
            _repository = repository;
        }

        public string Create(Reference reference)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reference> List()
        {
            return _repository.List();
        }
    }
}