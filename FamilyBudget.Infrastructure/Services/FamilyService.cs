using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.Persistence.Models;
using FamilyBudget.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.Infrastructure.Services
{
    public class FamilyService : IFamilyService
    {
        private readonly IGenericRepository<Family> _familyRepository;

        public FamilyService(IGenericRepository<Family> familyRepository)
        {
            _familyRepository = familyRepository;
        }

        public async Task<IEnumerable<Family>> GetFamiliesForUserAsync(int userId)
        {
            return await _familyRepository.FindWithIncludeAsync(
                f => f.Users.Any(u => u.Id == userId),
                f => f.Users
            );
        }
    }
}
