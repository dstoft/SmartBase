using System;
using System.Collections.Generic;
using SmartReference.Domain.Models;
using SmartReference.Domain.Interfaces;

namespace SmartReference.Infrastructure.Repositories
{
    public class ReferenceRepository : IReferenceRepository
    {
        private ReferenceContext _context;

        public ReferenceRepository(ReferenceContext context)
        {
            _context = context;
        }

        public IEnumerable<Reference> List()
        {
            return _context.References;
        }

        public string Create(Reference reference)
        {
            throw new NotImplementedException();
        }
    }
}