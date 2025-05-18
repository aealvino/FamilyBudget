using FamilyBudget.Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyBudget.ApplicationCore.Interfaces
{
    public interface IFamilyService
    {
        Task<IEnumerable<Family>> GetFamiliesForUserAsync(int userId);
    }

}
