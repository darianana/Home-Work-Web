using System;

namespace Fifth_HomeWork.Models
{
    public class Staging
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public St_type St_type { get; set; }
        public int Tickets { get; set; }
        public int Price { get; set; } 
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