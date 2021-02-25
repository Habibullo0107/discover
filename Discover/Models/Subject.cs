using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discover.Models
{
    public class Subject
    {
        private ILazyLoader LazyLoader;

        public Subject()
        {

        }

        public Subject(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        public Guid Guid { get; set; }

        public string Name { get; set; }

        List<Topic> topics;
        public virtual List<Topic> Topics
        {
            get
            {
                return LazyLoader.Load(this, ref topics);
            }
            set
            {
                topics = value;
            }
        }
    }
}
