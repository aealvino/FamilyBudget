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
    class FamilyConfig : IEntityTypeConfiguration<Family>
    {
        public void Configure(EntityTypeBuilder<Family> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Families__3214EC071A4CCBD3");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
