using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Web.Mvc;
using SydMeetup.PlacesDirectory.Models.Pages;
using SydMeetup.PlacesDirectory.Models.ViewModels;
using System.Web.Mvc;

namespace SydMeetup.PlacesDirectory.Controllers
{
    public class ExplorePageController : PageController<ExplorePage>
    {
        private readonly IClient _client;

        public ExplorePageController(IClient client)
        {
            _client = client;
        }

        public ActionResult Index(ExplorePage currentPage)
        {
            return View(new ExplorePageViewModel(currentPage)
            {
                ExploreItems = _client.Search<PlacePage>().GetContentResult()
            });
        }
    }
}