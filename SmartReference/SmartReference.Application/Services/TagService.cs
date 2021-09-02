using System.Collections.Generic;
using SmartReference.Application.Interfaces;
using SmartReference.Application.Parameters;
using SmartReference.Domain.Interfaces;
using SmartReference.Domain.Models;

namespace SmartReference.Application.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public Tag Get(string name)
        {
            return _tagRepository.Get(name);
        }

        public Tag Create(CreateTagParameters parameters)
        {
            var tag = Get(parameters.Name);
            if (tag != null) return tag;

            tag = new Tag(parameters.Name);
            _tagRepository.Create(tag);
            return tag;
        }

        public IEnumerable<Tag> List()
        {
            return _tagRepository.List();
        }
    }
}