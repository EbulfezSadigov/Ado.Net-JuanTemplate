﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Models
{
    public class Policy:BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string BackGround { get; set; }
    }
}
