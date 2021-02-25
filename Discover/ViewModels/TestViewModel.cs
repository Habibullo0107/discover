using Caliburn.Micro;
using Discover.Models;
using System;
using System.Collections.Generic;

namespace Discover.ViewModels
{
    public class TestViewModel : Conductor<object>
    {
        Topic topic;
        List<Question> questions;
        public Topic Topic
        {
            get { return topic; }
            set
            {
                topic = value;
                NotifyOfPropertyChange(nameof(Topic));
            }
        }
    }
}
