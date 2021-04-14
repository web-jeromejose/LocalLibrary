using System;
using System.Collections.Generic;
using System.Text;
using LocalLibrary.Localization;
using Volo.Abp.Application.Services;

namespace LocalLibrary
{
    /* Inherit your application services from this class.
     */
    public abstract class LocalLibraryAppService : ApplicationService
    {
        protected LocalLibraryAppService()
        {
            LocalizationResource = typeof(LocalLibraryResource);
        }
    }
}
