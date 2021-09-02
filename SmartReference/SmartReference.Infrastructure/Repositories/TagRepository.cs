using System.Collections.Generic;
using System.Linq;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Infrastructure.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ReferenceContext _context;

        public TagRepository(ReferenceContext context)
        {
            _context = context;
        }

        public string Create(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
            return tag.Name;
        }

        public Tag Get(string name)
        {
            return _context.Tags.FirstOrDefault(t => t.Name.Equals(name));
        }

        public IEnumerable<Tag> List()
        {
            return _context.Tags;
        }
    }
}