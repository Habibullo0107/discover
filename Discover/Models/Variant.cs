using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class Variant
    {
        public Guid Guid { get; set; }

        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public string  VariantText { get; set; }

        public bool IsCorrect { get; set; }

    }
}
