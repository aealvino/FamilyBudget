using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FamilyBudget.Persistence.Models;

namespace FamilyBudget.Persistence.Configurations
{
    class ExpenceConfig : IEntityTypeConfiguration<Expence>
    {
        public void Configure(EntityTypeBuilder<Expence> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Expences__3214EC075B22772E");

            builder.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.Date).HasColumnType("datetime");
            builder.Property(e => e.Description).HasMaxLength(255);
            builder.Property(e => e.IncomeCategoryId).HasColumnName("Income_category_id");
            builder.Property(e => e.UserId).HasColumnName("User_id");

            builder.HasOne(d => d.IncomeCategory).WithMany(p => p.Expences)
                .HasForeignKey(d => d.IncomeCategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Expences__Income__6EF57B66");

            builder.HasOne(d => d.User).WithMany(p => p.Expences)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Expences__User_i__6E01572D");
        }
    }
}
