using SpiderWeb.io.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SpiderWeb.io.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ioPageModel : AbpPageModel
    {
        protected ioPageModel()
        {
            LocalizationResourceType = typeof(ioResource);
        }
    }
}