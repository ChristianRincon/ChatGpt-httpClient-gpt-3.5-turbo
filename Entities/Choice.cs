﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Choice
    {
        public int? index { get; set; }
        public Message? message { get; set; }
        public string? finish_reason { get; set; }
    }
}
