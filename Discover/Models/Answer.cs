using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class Answer
    {
        public Guid Guid { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public Guid VarianrtId { get; set; }
        public virtual Variant Variant { get; set; }

        public bool IsCorrect { get; set; }
    }

   
}
