using SpiderWeb.io.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SpiderWeb.io.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ioController : AbpController
    {
        protected ioController()
        {
            LocalizationResource = typeof(ioResource);
        }
    }
}