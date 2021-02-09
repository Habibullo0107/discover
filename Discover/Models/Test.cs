using System;
using System.Collections.Generic;

namespace Discover.Models
{
    public class Test
    {
        public Guid Guid { get; set; }

        public string QuestionText { get; set; }

        public Guid MavzuId { get; set; }
        public virtual Mavzu Mavzu { get; set; }

        public virtual List<Javob> Javobho { get; set; }
    }
}
