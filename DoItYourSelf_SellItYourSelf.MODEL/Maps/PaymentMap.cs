using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class PaymentMap:CoreMap<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.Property(x => x.NameSurname).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.CardNumber).HasMaxLength(16).IsRequired(true);
            builder.Property(x => x.ExpirationDate).HasColumnType("Date").IsRequired(true);
            builder.Property(x => x.Cvc).HasMaxLength(3).IsRequired(true);

            base.Configure(builder);
        }
    }
}
