using System;

namespace SmartReference.Domain.Models
{
    public class ReferenceTag
    {
        public ReferenceTag(Guid id, string referenceName, string tagName)
        {
            Id = id;
            ReferenceName = referenceName;
            TagName = tagName;
        }

        public Guid Id { get; private set; }
        public string ReferenceName { get; private set; }
        public virtual Reference Reference { get; set; }
        public string TagName { get; private set; }
        public Tag Tag { get; set; }
    }
}