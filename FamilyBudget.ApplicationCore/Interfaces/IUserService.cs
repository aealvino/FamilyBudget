using FamilyBudget.Application.DTOs;
using FamilyBudget.Persistence.Models;

namespace FamilyBudget.Domain.Interfaces
{
    public interface IUserService
    {
        Task<int> RegisterAsync(UserRegisterDto registerDto);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User?> GetByIdAsync(int id);
        Task<User?> GetByEmailAsync(string email);
    }
}
