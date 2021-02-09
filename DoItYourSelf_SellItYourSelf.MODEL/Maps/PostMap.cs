using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class PostMap:CoreMap<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.Property(x => x.PostTitle).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.PostDetail).HasMaxLength(1000).IsRequired(true);
            builder.Property(x => x.ViewCount).IsRequired(false);
            builder.Property(x => x.ForSale).IsRequired(true);
            builder.Property(x => x.Rate).IsRequired(false);

            base.Configure(builder);
        }
    }
}
