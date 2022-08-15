using BN.Domain.NewsAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BN.Infrastrure.EFCore.Mapping
{
    public class NewsMapping : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News");
            builder.HasKey(x => x.NewsId);

            builder.Property(x => x.NewsTitle).HasMaxLength(200).IsRequired();

            builder.Property(x => x.NewsImage).IsRequired();

            builder.Property(x => x.NewsShortDescription).HasMaxLength(1000).IsRequired();

            builder.Property(x => x.NewsContent).IsRequired();

            builder.Property(x => x.CreationDate).IsRequired();

            //Relation Ship To NewsCategory
            builder.HasOne(x => x.NewsCategory)
                .WithMany(z => z.News).HasForeignKey(y => y.NewsCategoryId);


        }
    }
}
