using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace SpiderWeb.io.EntityFrameworkCore
{
    public static class ioDbContextModelCreatingExtensions
    {
        public static void Configureio(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ioConsts.DbTablePrefix + "YourEntities", ioConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}