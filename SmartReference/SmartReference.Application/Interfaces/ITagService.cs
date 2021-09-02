using System.Collections.Generic;
using SmartReference.Application.Parameters;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Interfaces
{
    public interface ITagService
    {
        public Tag Get(string name);
        public Tag Create(CreateTagParameters parameters);
        public IEnumerable<Tag> List();
    }
}