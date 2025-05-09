using FamilyBudget.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyBudget.Persistence.Configurations
{
    class ExpencesCategoryConfig : IEntityTypeConfiguration<ExpencesCategory>
    {
        public void Configure(EntityTypeBuilder<ExpencesCategory> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK__Expences__3214EC076AAB0666");

            builder.ToTable("Expences_categories");

            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
