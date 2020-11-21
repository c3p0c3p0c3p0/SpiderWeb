using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SpiderWeb.io.Data
{
    /* This is used if database provider does't define
     * IioDbSchemaMigrator implementation.
     */
    public class NullioDbSchemaMigrator : IioDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}