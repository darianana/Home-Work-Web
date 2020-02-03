﻿using System;
using System.Collections.Generic;
namespace TicketsStore.Models
{
    public class User
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Password{ get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
        
        public List<Bucket> Buckets { get; set; }

        public User()
        {
            Buckets = new List<Bucket>();
        } 
    }
}