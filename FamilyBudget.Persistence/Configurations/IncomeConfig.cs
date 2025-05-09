using FamilyBudget.Persistence.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.Persistence.Configurations
{
    class IncomeConfig : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Incomes__3214EC07C4203B49");

            builder.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.Date).HasColumnType("datetime");
            builder.Property(e => e.Description).HasMaxLength(255);
            builder.Property(e => e.IncomeCategoryId).HasColumnName("Income_category_id");
            builder.Property(e => e.UserId).HasColumnName("User_id");

            builder.HasOne(d => d.IncomeCategory).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.IncomeCategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Incomes__Income___693CA210");

            builder.HasOne(d => d.User).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Incomes__User_id__68487DD7");
        }
    }
}
