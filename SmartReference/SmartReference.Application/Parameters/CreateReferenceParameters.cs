using System.Collections.Generic;

namespace SmartReference.Application.Parameters
{
    public class CreateReferenceParameters
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Abstract { get; set; }
        public string Citation { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}