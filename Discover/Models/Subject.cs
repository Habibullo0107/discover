using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class Subject
    {
        public Guid Guid { get; set; }

        public string Nom { get; set; }

        public virtual List<Mavzu> Mavzuho { get; set; } = new List<Mavzu>();
    }
}
