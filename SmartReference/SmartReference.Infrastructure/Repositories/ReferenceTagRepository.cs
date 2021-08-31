using System;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Infrastructure.Repositories
{
    public class ReferenceTagRepository : IReferenceTagRepository
    {
        private readonly ReferenceContext _context;

        public ReferenceTagRepository(ReferenceContext context)
        {
            _context = context;
        }

        public Guid Create(ReferenceTag referenceTag)
        {
            _context.ReferenceTags.Add(referenceTag);
            _context.SaveChanges();
            return referenceTag.Id;
        }
    }
}