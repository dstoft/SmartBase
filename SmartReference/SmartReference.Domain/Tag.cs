using System;
using System.ComponentModel.DataAnnotations;

namespace SmartReference.Domain
{
    public class Tag
    {
        public Tag(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}