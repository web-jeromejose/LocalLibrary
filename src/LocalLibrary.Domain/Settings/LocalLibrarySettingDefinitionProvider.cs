using Volo.Abp.Settings;

namespace LocalLibrary.Settings
{
    public class LocalLibrarySettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LocalLibrarySettings.MySetting1));
        }
    }
}
