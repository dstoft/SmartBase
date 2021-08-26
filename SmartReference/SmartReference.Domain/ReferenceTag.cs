using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartReference.Domain
{
    public class ReferenceTag
    {
        public ReferenceTag(Guid id, string referenceName, Guid tagId)
        {
            Id = id;
            ReferenceName = referenceName;
            TagId = tagId;
        }
        public Guid Id { get; private set; }
        public string ReferenceName { get; private set; }
        public Reference Reference { get; set; }
        public Guid TagId { get; private set; }
        public Tag Tag { get; set; }
    }
}