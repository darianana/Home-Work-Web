﻿using System.Collections.Generic;

namespace MyEntity
{
    public class St_type
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public List<Staging> Stagings{ get; set; }
        public St_type()
        {
            Stagings = new List<Staging>();
        }
    }
}