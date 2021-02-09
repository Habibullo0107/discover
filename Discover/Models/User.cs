using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class User
    {
        public Guid Guid { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public UserStatus Status { get; set; }
    }

    public enum UserStatus
    {
        Blocked,
        Active,

    }
}
