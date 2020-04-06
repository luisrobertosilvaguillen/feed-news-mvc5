using System.Collections.Generic;

namespace Domain.Models
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<FeedNews> FeedNews { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
