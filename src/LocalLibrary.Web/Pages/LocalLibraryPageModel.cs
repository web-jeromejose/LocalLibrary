using LocalLibrary.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LocalLibrary.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class LocalLibraryPageModel : AbpPageModel
    {
        protected LocalLibraryPageModel()
        {
            LocalizationResourceType = typeof(LocalLibraryResource);
        }
    }
}