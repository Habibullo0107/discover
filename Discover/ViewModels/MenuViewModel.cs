using Caliburn.Micro;
using Discover.Models;
using Discover.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Discover.ViewModels
{

    public class MenuViewModel : Conductor<object>
    {
        public MainContext Context { get; set; }

        public MenuViewModel()
        {
            Context = new MainContext();
            Subjects = Context.GetEntities<Subject>().ToList();
          
        }

        public List<Subject> Subjects { get; set; }

    

        Subject subject;

     

        public Subject SelectedSubject
        {
            get
            {
                return subject;
            }
            set
            {
                Topics = Context.GetEntities<Topic>().Where(s => s.SubjectId == value.Guid).ToList();
                subject = value;
                NotifyOfPropertyChange(nameof(SelectedSubject));
            }
        }

       

        List<Topic> topics;
        public List<Topic> Topics
        {
            get
            {
                return topics;
            }
            set
            {
                topics = value;
                NotifyOfPropertyChange(nameof(Topics));
            }
        }
    }
}
