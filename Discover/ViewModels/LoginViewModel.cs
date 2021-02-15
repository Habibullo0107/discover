using Caliburn.Micro;
using Discover.Models;
using Discover.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Discover.ViewModels
{
    public class LoginViewModel : Conductor<object>
    {
        
        public string LoginText { get; set; }

        public string PasswordText { get; set; }
  
        public void LogIn()
        {
            using (MainContext context = new MainContext())
            {
                var userExists = context.GetEntities<User>().Any(s => s.Login == LoginText && s.Password == PasswordText);

                if (true)
                {
                    NavigationHelper.OpenWindow<MenuViewModel>();
                    TryClose();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

    }
}
