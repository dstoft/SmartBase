using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Infrastructure.Repositories
{
    public class ReferenceRepository : IReferenceRepository
    {
        private readonly ReferenceContext _context;

        public ReferenceRepository(ReferenceContext context)
        {
            _context = context;
        }

        public IEnumerable<Reference> List()
        {
            return _context.References;
        }

        public Reference Get(string name)
        {
            return _context.References.FirstOrDefault(r => r.Name.Equals(name));
        }

        public string Create(Reference reference)
        {
            _context.References.Add(reference);
            _context.SaveChanges();
            return reference.Name;
        }

        public IEnumerable<Reference> GetOnReferenceTagTag(Tag tag)
        {
            var query = from referenceTag in _context.ReferenceTags
                join reference in _context.References
                    on referenceTag.ReferenceName equals reference.Name
                where referenceTag.TagName == tag.Name
                select reference;
            return query.Include("ReferenceTags.Tag").ToList();
        }
    }
}