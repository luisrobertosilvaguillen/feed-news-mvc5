using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class HomeViewModel
    {
        public ICollection<FeedNews> feedNews { get; set; }
        public HomeViewModel(ICollection<FeedNews> feedNews)
        {
            this.feedNews = feedNews;
        }
    }
}