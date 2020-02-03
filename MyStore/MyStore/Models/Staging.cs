using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace MyStore.Models
{
    public class Staging
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime StartTime { get; set; }

        public int TheaterId { get; set; }

        public Theater Theater { get; set; }
        public List<Bucket> BucketEntries { get; } = new List<Bucket>();
    }
}