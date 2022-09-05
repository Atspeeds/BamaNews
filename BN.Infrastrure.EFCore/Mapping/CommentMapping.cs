using BN.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BN.Infrastrure.EFCore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(x => x.Comment_Id);

            builder.Property(x => x.TitleComment).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(500).IsRequired();
            builder.Property(x => x.StatusComment).IsRequired();
            builder.Property(x => x.Creationdate).IsRequired();

            //Relation Ship To News
            builder.HasOne(x => x.News).WithMany(z => z.Comments)
                .HasForeignKey(y=>y.NewsId);

            //Relation Ship To User
            builder.HasOne(x => x.Users).WithMany(z => z.Comment)
                .HasForeignKey(y => y.UserId);

        }
    }
}
