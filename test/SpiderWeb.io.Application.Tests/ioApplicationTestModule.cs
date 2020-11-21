using Volo.Abp.Modularity;

namespace SpiderWeb.io
{
    [DependsOn(
        typeof(ioApplicationModule),
        typeof(ioDomainTestModule)
        )]
    public class ioApplicationTestModule : AbpModule
    {

    }
}