using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class RoleMap:CoreMap<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.Property(x => x.RoleName).IsRequired(true).HasMaxLength(15);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(50);
            base.Configure(builder);
        } 
    }
}
