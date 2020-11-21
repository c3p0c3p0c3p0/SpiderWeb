using System;
using System.Collections.Generic;
using System.Text;
using SpiderWeb.io.Localization;
using Volo.Abp.Application.Services;

namespace SpiderWeb.io
{
    /* Inherit your application services from this class.
     */
    public abstract class ioAppService : ApplicationService
    {
        protected ioAppService()
        {
            LocalizationResource = typeof(ioResource);
        }
    }
}
