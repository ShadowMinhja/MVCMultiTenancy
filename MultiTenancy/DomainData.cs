﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiTenancy
{
    public class DomainData
    {
        public string Protocol { get; set; }
        public string HostName { get; set; }
        public string Fragment { get; set; }
    }
}
