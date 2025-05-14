using System;
using System.Collections.Generic;

namespace FamilyBudget.Persistence.Models;

public partial class Family
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Goal> Goals { get; set; } = new List<Goal>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
