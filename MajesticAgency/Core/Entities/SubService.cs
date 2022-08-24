﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class SubService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
