﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_linq
{
    public class Publisher
    {
        public string Name { get; set; }
        public string WebSite { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
