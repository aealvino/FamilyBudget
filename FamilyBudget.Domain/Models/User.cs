using System;
using System.Collections.Generic;

namespace FamilyBudget.Persistence.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public decimal Balance { get; set; }

    public int? FamilyId { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Expence> Expences { get; set; } = new List<Expence>();

    public virtual Family? Family { get; set; }

    public virtual ICollection<Income> Incomes { get; set; } = new List<Income>();

    public virtual Role? Role { get; set; }
}
