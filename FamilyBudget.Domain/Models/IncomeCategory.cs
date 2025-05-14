using System;
using System.Collections.Generic;

namespace FamilyBudget.Persistence.Models;

public partial class IncomeCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Income> Incomes { get; set; } = new List<Income>();
}
