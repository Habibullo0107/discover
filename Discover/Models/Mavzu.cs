﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Discover.Models
{
    public class Mavzu
    {
        public Guid Guid { get; set; }

        public Guid SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual List<Test> Testho { get; set; }
        public string Nom { get; set; }
    }
}
