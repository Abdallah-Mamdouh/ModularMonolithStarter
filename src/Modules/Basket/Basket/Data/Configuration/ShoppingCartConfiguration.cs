using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Basket.Data.Configuration
{
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserName)
                    .IsUnicode();

            builder.Property(p => p.UserName)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.HasMany(p => p.Items)
                .WithOne()
                .HasForeignKey(p => p.ShoppingCartId);
        }
    }
}
