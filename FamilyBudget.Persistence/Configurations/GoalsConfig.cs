using FamilyBudget.Persistence.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Persistence.Configurations
{
    public class GoalsConfig : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Goals__3214EC070EF45D0F");

            builder.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("Create_date");
            builder.Property(e => e.CurrentAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Current_amount");
            builder.Property(e => e.Deadline).HasColumnType("datetime");
            builder.Property(e => e.FamilyId).HasColumnName("Family_id");
            builder.Property(e => e.IsCompleted).HasDefaultValue(false);
            builder.Property(e => e.TargetAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Target_amount");
            builder.Property(e => e.Title).HasMaxLength(100);

            builder.HasOne(d => d.Family).WithMany(p => p.Goals)
                .HasForeignKey(d => d.FamilyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Goals__Family_id__5FB337D6");
        }
    }
}
