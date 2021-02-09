using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class CommentMap:CoreMap<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.Property(x => x.CommentTitle).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.CommentText).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Score).IsRequired(false);


            base.Configure(builder);
        }
    }
}
