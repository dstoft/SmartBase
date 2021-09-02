using System.Collections.Generic;
using SmartReference.Domain.Models;

namespace SmartReference.Domain.Interfaces
{
    public interface ITagRepository
    {
        public string Create(Tag tag);
        public Tag Get(string name);
        public IEnumerable<Tag> List();
    }
}