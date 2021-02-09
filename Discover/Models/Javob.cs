using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class Javob
    {
        public Guid Guid { get; set; }

        public Guid TestId { get; set; }
        public virtual Test Test { get; set; }

        public Variant Variant { get; set; }

        public string JavobText { get; set; }

        public bool Durust { get; set; }
    }

    public enum Variant
    {
        A,
        B,
        C,
        D
    }
}
