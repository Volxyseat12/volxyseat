using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volxyseat.Domain.Models;
using Volxyseat.Infrastructure.Data;

namespace Volxyseat.Infrastructure.Configurations
{
    public class SubscriptionEntityConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscription", DataContext.DEFAULT_SCHEMA);

            builder.Property(_ => _.Id)
                .ValueGeneratedNever();

            builder.Property(s => s._typeId)
                .HasConversion(
                    v => (int)v,
                    v => (SubscriptionEnum)v)
                .HasColumnName("TypeId")
                .IsRequired();

            builder.Property(s => s._statusId) 
                .HasConversion(
                    v => (int)v,
                    v => (SubscriptionStatus)v)
                .HasColumnName("StatusId")
                .IsRequired();

            builder.HasMany(s => s.Histories)
                   .WithOne()
                   .HasForeignKey("SubscriptionId")
                   .IsRequired();

            builder.Property(s => s.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValue(new DateTime(2000, 1, 1))
                .IsRequired();

            builder.Property(s => s.UpdatedOn)
                .HasColumnType("datetime")
                .HasDefaultValue(new DateTime(2000, 1, 1))
                .IsRequired();
        }
    }
}
