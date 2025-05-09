using System;
using System.Collections.Generic;
using FamilyBudget.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.Persistence;

public partial class FamilyBudgetContext : DbContext
{
    public FamilyBudgetContext()
    {
    }

    public FamilyBudgetContext(DbContextOptions<FamilyBudgetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Expence> Expences { get; set; }

    public virtual DbSet<ExpencesCategory> ExpencesCategories { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<IncomeCategory> IncomeCategories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlServer("Server=aelavino\\MSSQLSERVER01;Database=FamilyBudget; Trust Server Certificate=True; Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var applicationContextAssembly = typeof(FamilyBudgetContext).Assembly;

        modelBuilder.ApplyConfigurationsFromAssembly(applicationContextAssembly);
    }
}
