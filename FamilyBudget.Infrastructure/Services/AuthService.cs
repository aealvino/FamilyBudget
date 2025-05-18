using FamilyBudget.ApplicationCore.DTOs;
using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.Persistence.Models;
using FamilyBudget.Persistence.Repositories.Interfaces;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IUserSessionService _userSessionService;

        public AuthService(IGenericRepository<User> userrepository,IUserSessionService userSessionService)
        {
            _userRepository = userrepository;
            _userSessionService = userSessionService;
        }

        public async Task<int> LoginUser(UserLoginDTO dto)
        {
            var hashedPassword = HashPassword(dto.PasswordHash);

            var user = (await _userRepository.FindAsync(u =>
                u.Email == dto.Email && u.PasswordHash == hashedPassword))
                .FirstOrDefault();
            _userSessionService.SetLoggedIn(true);
            return user.Id;
        }
        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
