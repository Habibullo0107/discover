using Discover.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Discover.ViewModels
{
    public class MenuViewModel
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
                Mavzuho = Context.GetEntities<Mavzu>().Where(s => s.SubjectId == value.Guid).ToList();
                subject = value;
            }
        }


        public List<Mavzu> Mavzuho { get; set; }
    }
}
