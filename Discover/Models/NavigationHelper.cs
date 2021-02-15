using Caliburn.Micro;
using System;

namespace Discover.Models
{
    public static class NavigationHelper
    {
        public static void OpenWindow<T>() where T : class
        {
            WindowManager windowManager = new WindowManager();
            windowManager.ShowWindow(Activator.CreateInstance<T>());
        }
    }
}
