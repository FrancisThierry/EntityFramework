﻿using System;
using System.Collections.Generic;

namespace SQliteSimpleEF.Models
{
    public partial class Contact
    {
        public long Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
    }
}
