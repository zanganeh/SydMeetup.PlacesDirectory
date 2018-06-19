using System.Web;
using System.Web.Mvc;
using EPiServer.SpecializedProperties;

namespace SydMeetup.PlacesDirectory.Models.ViewModels
{
    public class LayoutModel
    {
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }
        public bool LoggedIn { get; set; }

        public bool IsInReadonlyMode { get; set; }
    }
}