using Discover.Models;
using Discover.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Discover.ViewModels
{
    public class LoginViewModel
    {
        public string LoginText { get; set; }

        public string PasswordText { get; set; }



        public void LogIn()
        {
            using (MainContext context = new MainContext())
            {
                var userExists = context.GetEntities<User>().Any(s => s.Login == LoginText && s.Password == PasswordText);

                if (userExists)
                {
                    MenuView menuView = new MenuView();
                    menuView.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
