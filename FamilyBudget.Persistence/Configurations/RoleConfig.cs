using FamilyBudget.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Persistence.Configurations
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Устанавливаем первичный ключ
            builder.HasKey(e => e.Id).HasName("PK_Roles");

            // Указываем имя таблицы
            builder.ToTable("Roles");

            // Указываем дополнительные свойства
            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
