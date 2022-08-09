using BN.Domain.NewsCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BN.Infrastrure.EFCore.Mapping
{
    class NewsCategoryMapping : IEntityTypeConfiguration<NewsCategory>
    {
        public void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            builder.HasKey(x => x.CategoryId);

            builder.Property(x => x.CategoryName)
                .HasMaxLength(255).IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(500).IsRequired();


            //Relation Ship To NewsCategory
            builder.HasMany(x => x.News)
                .WithOne(z => z.NewsCategory).HasForeignKey(y => y.NewsCategoryId);


        }
    }
}
