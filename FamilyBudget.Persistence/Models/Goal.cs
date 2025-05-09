using System;
using System.Collections.Generic;

namespace FamilyBudget.Persistence.Models;

public partial class Goal
{
    public int Id { get; set; }

    public int? FamilyId { get; set; }

    public string Title { get; set; } = null!;

    public decimal TargetAmount { get; set; }

    public decimal CurrentAmount { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime Deadline { get; set; }

    public byte Priority { get; set; }

    public bool? IsCompleted { get; set; }

    public virtual Family? Family { get; set; }
}
