using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SpiderWeb.io.EntityFrameworkCore
{
    [DependsOn(
        typeof(ioEntityFrameworkCoreModule)
        )]
    public class ioEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ioMigrationsDbContext>();
        }
    }
}
