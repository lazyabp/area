using Lazy.Abp.AreaKit;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lazy.Abp.AreaKit.EntityFrameworkCore
{
    public static class AreaKitDbContextModelCreatingExtensions
    {
        public static void ConfigureAreaKit(
            this ModelBuilder builder,
            Action<AreaKitModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AreaKitModelBuilderConfigurationOptions(
                AreaKitDbProperties.DbTablePrefix,
                AreaKitDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */


            builder.Entity<Country>(b =>
            {
                b.ToTable(options.TablePrefix + "Countries", options.Schema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<StateProvince>(b =>
            {
                b.ToTable(options.TablePrefix + "StateProvinces", options.Schema);
                b.ConfigureByConvention();

                //b.HasOne(m => m.Country).WithMany().OnDelete(DeleteBehavior.NoAction);
                /* Configure more properties here */
            });

            builder.Entity<City>(b =>
            {
                b.ToTable(options.TablePrefix + "Cities", options.Schema);
                b.ConfigureByConvention();

                //b.HasOne(m => m.Country).WithMany().OnDelete(DeleteBehavior.NoAction);
                //b.HasOne(m => m.StateProvince).WithMany().OnDelete(DeleteBehavior.NoAction);
                /* Configure more properties here */
            });


            builder.Entity<Address>(b =>
            {
                b.ToTable(options.TablePrefix + "Addresses", options.Schema);
                b.ConfigureByConvention();

                //b.HasOne(m => m.Country).WithMany().OnDelete(DeleteBehavior.NoAction);
                //b.HasOne(m => m.City).WithMany().OnDelete(DeleteBehavior.NoAction);
                /* Configure more properties here */
            });
        }
    }
}
