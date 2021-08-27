using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartReference.Domain.Models
{
    public class Reference
    {
        public Reference(string name, string link, string summary, string citation)
        {
            Name = name;
            Link = link;
            Summary = summary;
            Citation = citation;
        }
        
        [Key]
        public string Name { get; private set; }
        public string Link { get; private set; }
        public string Summary { get; private set; }
        public string Citation { get; private set; }
        public ICollection<ReferenceTag> ReferenceTags { get; } = new List<ReferenceTag>();
    }
}