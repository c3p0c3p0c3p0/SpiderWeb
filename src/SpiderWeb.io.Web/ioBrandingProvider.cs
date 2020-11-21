using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace SpiderWeb.io.Web
{
    [Dependency(ReplaceServices = true)]
    public class ioBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "io";
    }
}
