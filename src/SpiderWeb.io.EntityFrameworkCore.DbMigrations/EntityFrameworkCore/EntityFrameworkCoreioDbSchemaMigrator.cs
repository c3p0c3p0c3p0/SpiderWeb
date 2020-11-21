using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpiderWeb.io.Data;
using Volo.Abp.DependencyInjection;

namespace SpiderWeb.io.EntityFrameworkCore
{
    public class EntityFrameworkCoreioDbSchemaMigrator
        : IioDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreioDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ioMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ioMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}