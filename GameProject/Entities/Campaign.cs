﻿using GameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Campaign
    {
        public int Id { get; set; }
        public int DiscountRate { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
    }
}
