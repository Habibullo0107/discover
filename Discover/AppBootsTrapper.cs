using Caliburn.Micro;
using Discover.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Discover
{
    public class AppBootsTrapper : BootstrapperBase
    {
        public AppBootsTrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MenuViewModel>();
        }
    }
}
