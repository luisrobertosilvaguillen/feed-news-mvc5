
using Domain.DTO.Category;
using Domain.DTO.FeedNews;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class FooterViewModel
    {
        public ICollection<NewsByCategory> categories { get; set; }
        public ICollection<NewsByFeedNews> feedNews { get; set; }
        public FooterViewModel(ICollection<NewsByCategory> categories, ICollection<NewsByFeedNews> feedNews)
        {
            this.categories = categories;
            this.feedNews = feedNews;
        }
    }
}