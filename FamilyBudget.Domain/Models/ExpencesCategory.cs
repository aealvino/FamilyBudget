using System;
using System.Collections.Generic;

namespace FamilyBudget.Persistence.Models;

public partial class ExpencesCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Expence> Expences { get; set; } = new List<Expence>();
}
