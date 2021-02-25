using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;

namespace Discover.Models
{
    public class Question
    {
        private ILazyLoader _lazyLoader;
        public Question()
        {

        }

        public Question(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        public Guid Guid { get; set; }

        public string QuestionText { get; set; }

        public Guid TopicId { get; set; }
        public virtual Topic Topic { get; set; }

        public virtual List<Answer> UserAnswers { get; set; }
        public virtual List<Variant> Variants { get; set; }
    }
}
