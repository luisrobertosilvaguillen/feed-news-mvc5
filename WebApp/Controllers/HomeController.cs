using Domain.Models;
using Services.FeedNews;
using Services.News;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public INewsService newsService;
        public IFeedNewsService feedFewsService;
        public HomeController(INewsService newsService, IFeedNewsService feedFewsService)
        {
            this.newsService = newsService;
            this.feedFewsService = feedFewsService;
        }
        public async Task<ActionResult> Index()
        {
            ICollection<FeedNews> feedNews = await feedFewsService.GetAsync();
            HomeViewModel model = new HomeViewModel(feedNews);
            return View(model);
        }
        public ActionResult Footer()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}