using Volo.Abp.Settings;

namespace SpiderWeb.io.Settings
{
    public class ioSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ioSettings.MySetting1));
        }
    }
}
