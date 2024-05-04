using IMS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure.Entity_Configration
{
    public class StoreConfigration : IEntityTypeConfiguration<StoreInfo>
    {
        public void Configure(EntityTypeBuilder<StoreInfo> builder)
        {
            builder.HasKey(e => e.Id);
                builder.Property(e=>e.Id)
             .ValueGeneratedOnAdd();

            builder.Property(e => e.StoreName)
                .IsRequired()
                .IsUnicode(true)
                .HasMaxLength(256);

            builder.Property(e => e.Address)
                .IsRequired()
                .IsUnicode(true)
                .HasMaxLength(256);

            builder.Property(e => e.PhoneNumber)
                .IsRequired()
                .IsUnicode(true)
                .HasMaxLength(256);

            builder.Property(e => e.RegistrationNo)
                .IsRequired()
                .IsUnicode(true)
                .HasMaxLength(256);

            builder.Property(e => e.PanNo)
               .IsRequired()
               .IsUnicode(true)
               .HasMaxLength(256);

            builder.Property(e => e.IsActive)
                   .IsRequired()
                   .HasDefaultValue(true);

            builder.Property(e => e.UpdatedBy)
              .HasMaxLength(50);

            builder.Property(e => e.CreatedBy)
              .HasMaxLength(50);

            builder.Property(e => e.UpdatedDate)
              .IsRequired()
              .HasDefaultValueSql("GETDATE()");

            builder.Property(e => e.CreatedDate)
              .IsRequired()
              .HasDefaultValueSql("GETDATE()");
        }
    }
}
