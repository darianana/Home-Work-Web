using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEntity_6_2.Models
{
    public class St_type
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual List<Staging> Stagings { get; set; }
        public St_type()
        {
            Stagings = new List<Staging>();
        }
    }
}
