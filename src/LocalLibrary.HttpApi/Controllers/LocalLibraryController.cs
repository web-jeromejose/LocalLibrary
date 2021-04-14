using LocalLibrary.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LocalLibrary.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LocalLibraryController : AbpController
    {
        protected LocalLibraryController()
        {
            LocalizationResource = typeof(LocalLibraryResource);
        }
    }
}