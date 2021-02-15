using System;
using System.Collections.Generic;

namespace Discover.Models
{
    public class Question
    {
        public Guid Guid { get; set; }

        public string QuestionText { get; set; }

        public Guid TopicId { get; set; }
        public virtual Topic Topic { get; set; }

        public virtual List<Answer> UserAnswers { get; set; }
        public virtual List<Variant> Variants { get; set; }
    }
}
