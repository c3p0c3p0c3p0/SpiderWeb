using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SpiderWeb.io.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ioHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ioConsoleApiClientModule : AbpModule
    {
        
    }
}
