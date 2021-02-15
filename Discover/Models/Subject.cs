using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class Subject
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public virtual List<Topic> Topics { get; set; } = new List<Topic>();
    }
}
