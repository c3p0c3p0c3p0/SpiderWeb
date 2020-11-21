using Microsoft.EntityFrameworkCore;
using SpiderWeb.io.Sources;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SpiderWeb.io.EntityFrameworkCore
{
    public static class ioDbContextModelCreatingExtensions
    {
        public static void Configureio(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Source>(b =>
            {
                b.ToTable(ioConsts.DbTablePrefix + "Sources",
                          ioConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}