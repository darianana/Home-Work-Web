using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEntity_6_2.Models
{
    public class Staging
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int St_typeId { get; set; }
        public virtual St_type St_type { get; set; }
        public int Tickets { get; set; }
        public int Price { get; set; }
    }
}
