using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discover.Models
{
    public class Topic
    {
        public Guid Guid { get; set; }
        public Guid SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        List<Question> questions;

        public virtual List<Question> Questions
        {
            get
            {
                if (questions == null)
                {
                    using (MainContext context = new MainContext())
                    {
                        questions = context.GetEntities<Question>()
                            .Include(x=>x.Variants)
                            .Where(s => s.TopicId == Guid).ToList();
                    }
                }
                return questions;

            }
            set
            {
                questions = value;
            }
        }

        public string Name { get; set; }
    }
}
