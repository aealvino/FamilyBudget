using FamilyBudget.Application.DTOs;
using FamilyBudget.Domain.Interfaces;
using FamilyBudget.Persistence;
using FamilyBudget.Persistence.Models;
using FamilyBudget.Persistence.Repositories;
using FamilyBudget.Persistence.Repositories.Interfaces;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Infrastructure.Services
{
    class UserService : IUserService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<int> RegisterAsync(UserRegisterDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name) ||
                string.IsNullOrWhiteSpace(dto.SecondName) ||
                string.IsNullOrWhiteSpace(dto.Email) ||
                string.IsNullOrWhiteSpace(dto.PasswordHash))
            {
                throw new ArgumentException("All fields are required.");
            }

            if (dto.PasswordHash.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters long.");
            }

            var existing = await _userRepository.FindAsync(u => u.Email == dto.Email);
            if (existing.Any())
            {
                throw new ArgumentException("A user with this email already exists.");
            }

            var user = _mapper.Map<User>(dto);
            user.PasswordHash = HashPassword(dto.PasswordHash);

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return 1;
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
