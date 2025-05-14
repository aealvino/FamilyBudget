using FamilyBudget.Application.DTOs;

namespace FamilyBudget.Domain.Interfaces
{
    public interface IUserService
    {
        Task<int> RegisterAsync(UserRegisterDto registerDto);
    }
}
