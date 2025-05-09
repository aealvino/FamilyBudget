using System;
using System.Collections.Generic;

namespace FamilyBudget.Persistence.Models;

public partial class Income
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? IncomeCategoryId { get; set; }

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public string? Description { get; set; }

    public virtual IncomeCategory? IncomeCategory { get; set; }

    public virtual User? User { get; set; }
}
