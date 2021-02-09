using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class UserMap:CoreMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Surname).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Password).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Gender).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.ImageURL).HasMaxLength(255).IsRequired(false);
            builder.Property(x => x.Phone).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.AccountInfo).HasMaxLength(255).IsRequired(false);

            base.Configure(builder);
        }
    }
}
