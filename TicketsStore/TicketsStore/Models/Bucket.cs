using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsStore.Models
{
    public class Bucket
    {
        public int UserId { get; set; }
        public int StagingId { get; set; }
        public int Quantity { get; set; }
    }
}
