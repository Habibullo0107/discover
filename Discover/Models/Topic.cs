using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class Topic
    {
        public Guid Guid { get; set; }

        public Guid SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual List<Question> Questions { get; set; }
        public string Name { get; set; }
    }
}
