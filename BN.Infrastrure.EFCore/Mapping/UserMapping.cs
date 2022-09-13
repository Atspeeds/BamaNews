using BN.Domain.UserAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BN.Infrastrure.EFCore.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName).HasMaxLength(60).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.Property(x => x.UserName).HasMaxLength(60).IsRequired();

            builder.Property(x => x.UserRole).HasMaxLength(255).IsRequired();

            builder.Property(x => x.Creationdate).IsRequired();

            builder.Property(x => x.UserAvatar).HasMaxLength(500).IsRequired();

            builder.Property(x => x.Passwoard).HasMaxLength(15).IsRequired();

            builder.Property(x => x.IsAdmin).IsRequired();

            //Relation Ship To Comment
            builder.HasMany(x => x.Comment).WithOne(z => z.Users)
                    .HasForeignKey(y => y.UserId);

        }
    }
}
