using Services.Category;
using Services.FeedNews;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SharedController : Controller
    {
        ICategoryService CategoryService;
        IFeedNewsService FeedNewsService;
        public SharedController(ICategoryService categoryService, IFeedNewsService feedNewsService)
        {
            this.CategoryService = categoryService;
            this.FeedNewsService = feedNewsService;
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            var categories = CategoryService.GetNewsByCategory(5);
            var feedNews = FeedNewsService.GetNewsByFeedNews(5);
            FooterViewModel footerViewModel = new FooterViewModel(categories, feedNews);
            return PartialView("Footer", footerViewModel);
        }
    }
}