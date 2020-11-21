using SpiderWeb.io.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SpiderWeb.io.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ioEntityFrameworkCoreDbMigrationsModule),
        typeof(ioApplicationContractsModule)
        )]
    public class ioDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
