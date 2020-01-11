using System;

namespace Fifth_HomeWork.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        
        public TimeSpan LifeTime
        {
            get
            {
                return DateTime.Now - CreationDate;
            }
        }
    }
}