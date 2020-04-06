using System;

namespace Domain.Models
{
    public class Comments : EntityBase
    {
        public Comments()
        {
            Date = DateTime.Now;
        }
        public string Comment { get; set; }
        public DateTime Date { get; set; }


        public int NewsId { get; set; }
        public virtual News News { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
