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
    class IncomeCategoryConfig : IEntityTypeConfiguration<IncomeCategory>
    {
        public void Configure(EntityTypeBuilder<IncomeCategory> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Income_c__3214EC07E84C4CDD");

            builder.ToTable("Income_categories");

            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
