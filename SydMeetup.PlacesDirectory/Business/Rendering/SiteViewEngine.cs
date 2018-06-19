using System.Linq;
using System.Web.Mvc;

namespace SydMeetup.PlacesDirectory.Business.Rendering
{
    /// <summary>
    /// Extends the Razor view engine to include the folders ~/Views/Shared/Blocks/ and ~/Views/Shared/PagePartials/
    /// when looking for partial views.
    /// </summary>
    public class SiteViewEngine : RazorViewEngine
    {
        const string BlockFolder = "~/Views/Shared/Blocks/";
        const string PagePartialsFolder = "~/Views/Shared/PagePartials/";

        private static readonly string[] AdditionalPartialViewFormats = new[]
            {
                BlockFolder + "{0}.cshtml",
                PagePartialsFolder + "{0}.cshtml"
            };

        public SiteViewEngine()
        {
            PartialViewLocationFormats = PartialViewLocationFormats.Union(AdditionalPartialViewFormats).ToArray();
        }
    }
}