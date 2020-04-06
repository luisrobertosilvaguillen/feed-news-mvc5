using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class News : EntityBase
    {
        public string Title { get; set; }
        public string HtmlContent { get; set; }
        public string Author { get; set; }
        public string VideoUrl { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }

        public int FeedNewsId { get; set; }
        public virtual FeedNews FeedNews { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }

    }
}
