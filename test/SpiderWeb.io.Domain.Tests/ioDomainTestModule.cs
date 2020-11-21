using SpiderWeb.io.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SpiderWeb.io
{
    [DependsOn(
        typeof(ioEntityFrameworkCoreTestModule)
        )]
    public class ioDomainTestModule : AbpModule
    {

    }
}