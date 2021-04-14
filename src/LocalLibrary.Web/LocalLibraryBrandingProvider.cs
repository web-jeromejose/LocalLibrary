using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LocalLibrary.Web
{
    [Dependency(ReplaceServices = true)]
    public class LocalLibraryBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LocalLibrary";
    }
}
