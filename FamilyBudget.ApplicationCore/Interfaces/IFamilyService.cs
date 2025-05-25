using FamilyBudget.Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FamilyBudget.ApplicationCore.Interfaces
{
    public interface IFamilyService
    {
        Task<IEnumerable<Family>> GetFamiliesForUserAsync(int userId);
        Task<IEnumerable<User>> GetUsersInFamilyAsync(int familyId);
        Task CreateFamilyAsync(string name, int userId);
        Task DeleteFamilyAsync(int familyId);
        Task<bool> IsUserFamilyOwnerAsync(int familyId, int userId);
        Task RemoveUsersFromFamilyAsync(int familyId, List<int> userIds);
    }

}
