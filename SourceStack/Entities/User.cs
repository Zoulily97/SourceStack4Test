﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.Entities
{
    public class User:Entity
    {
        public string Name { get; set; }
        public bool IsMale { get; set; }
    }
}
