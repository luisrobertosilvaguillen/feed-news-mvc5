using System.Collections.Generic;

namespace Domain.Models
{
    public class FeedNews : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<User> Subscribers { get; set; }

    }
}
