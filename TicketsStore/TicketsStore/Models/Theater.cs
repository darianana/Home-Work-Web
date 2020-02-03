using System;
using System.Collections.Generic;
namespace TicketsStore.Models
{
    public class Theater
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public TimeSpan  OpenTime{ get; set; }
        public TimeSpan  CloseTime{ get; set; }
        
        public List<Staging> Stagings { get; set; }

        public Theater()
        {
            Stagings = new List<Staging>();
        }  
    }
}