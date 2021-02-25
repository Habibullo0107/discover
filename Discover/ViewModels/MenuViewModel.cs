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
            TestViewModel = new TestViewModel();
            ActiveItem = TestViewModel;
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
                subject = value;
                NotifyOfPropertyChange(nameof(SelectedSubject));
            }
        }

        Topic topic;
        public Topic SelectedTopic
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
                TestViewModel.Topic = value;
                NotifyOfPropertyChange(nameof(SelectedTopic));
            }
        }

        object selectedTreeViewItem;
        public object SelectedTreeViewItem
        {
            get
            {
                return selectedTreeViewItem;
            }
            set
            {
                if (value is Subject subject)
                {
                    SelectedSubject = subject;
                }
                else if (value is Topic topic)
                {
                    //TODO set selected topic
                    SelectedTopic = topic;
                }
                selectedTreeViewItem = value;
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


        TestViewModel testViewModel;
        public TestViewModel TestViewModel
        {
            get
            {
                return testViewModel;
            }
            set { testViewModel = value; NotifyOfPropertyChange(nameof(TestViewModel)); }
        }
    }
}
