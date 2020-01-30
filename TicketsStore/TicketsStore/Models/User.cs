using System;
using System.Collections.Generic;
namespace TicketsStore.Models
{
    public class User
    {
        public enum Type
        {
            Admin,
            Moderator,
            Consultant,
            Customer
        }
        
        public int Id{ get; set; }
        public Type UserType{ get; set; }
        public string Name { get; set; }
        public string Password{ get; set; }
        public string Salt{ get; set; }

        public List<Bucket> Buckets { get; set; }

        public User()
        {
            Buckets = new List<Bucket>();
        }
    }
}