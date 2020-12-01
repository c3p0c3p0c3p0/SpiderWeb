using Microsoft.EntityFrameworkCore;
using SpiderWeb.io.Domain;
using SpiderWeb.io.Users;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;

namespace SpiderWeb.io.EntityFrameworkCore
{
    public static class ioDbContextModelCreatingExtensions
    {
        public static void Configureio(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

           

            builder.Entity<Source>(b =>
            {
                b.ToTable(ioConsts.DbTablePrefix + "Source",
                          ioConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            });
            builder.Entity<Page>(b =>
            {
                b.ToTable(ioConsts.DbTablePrefix + "Page",
                          ioConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            });
            builder.Entity<Comment>(b =>
            {
                b.ToTable(ioConsts.DbTablePrefix + "Comment",
                          ioConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            });
            builder.Entity<Reply>(b =>
            {
                b.ToTable(ioConsts.DbTablePrefix + "Reply",
                          ioConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            });
            //builder.Entity<AppUser>(b =>
            //{
            //    b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser

            //    b.ConfigureFullAudited();
            //    b.ConfigureExtraProperties();
            //    b.ConfigureConcurrencyStamp();

            //    //Moved customization to a method so we can share it with the HolyschoolMigrationsDbContext class
 
            //});
        }
    }
}