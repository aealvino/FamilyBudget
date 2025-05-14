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
    class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Users__3214EC072B904E3F");

            builder.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_of_birth");
            builder.Property(e => e.Email).HasMaxLength(100);
            builder.Property(e => e.FamilyId).HasColumnName("Family_id");
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.PasswordHash)
                .HasMaxLength(100)
                .HasColumnName("Password_hash");
            builder.Property(e => e.SecondName)
                .HasMaxLength(100)
                .HasColumnName("Second_name");

            builder.HasOne(d => d.Family).WithMany(p => p.Users)
                .HasForeignKey(d => d.FamilyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Users__Family_id__6383C8BA");

            builder.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_Users_Roles");
        }
    }
}
