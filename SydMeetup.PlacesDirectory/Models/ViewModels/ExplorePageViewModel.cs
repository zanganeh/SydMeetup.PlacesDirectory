using EPiServer.Find.Cms;
using SydMeetup.PlacesDirectory.Models.Pages;

namespace SydMeetup.PlacesDirectory.Models.ViewModels
{
    public class ExplorePageViewModel : PageViewModel<ExplorePage>
    {
        public ExplorePageViewModel(ExplorePage currentPage) : base(currentPage)
        {
        }

        public IContentResult<PlacePage> ExploreItems { get; set; }
    }
}