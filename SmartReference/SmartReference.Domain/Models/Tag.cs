using System.ComponentModel.DataAnnotations;

namespace SmartReference.Domain.Models
{
    public class Tag
    {
        public Tag(string name)
        {
            Name = name;
        }

        [Key] public string Name { get; private set; }
    }
}