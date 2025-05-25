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
        private readonly IGenericRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public UserService(
            IGenericRepository<User> userRepository,
            IGenericRepository<Role> roleRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<int> RegisterAsync(UserRegisterDto dto)
        {
            var existing = await _userRepository.FindAsync(u => u.Email == dto.Email);
            if (existing.Any())
            {
                throw new ArgumentException("Такой пользователь уже зарегестрирован");
            }
            var userRole = (await _roleRepository.FindAsync(r => r.Name == "Пользователь")).FirstOrDefault();
            if (userRole == null)
                throw new Exception("Роль 'Пользователь' не найдена в базе данных.");


            var user = _mapper.Map<User>(dto);
            user.PasswordHash = HashPassword(dto.PasswordHash);
            user.RoleId = userRole.Id;

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return user.Id;
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }
        public async Task<User?> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }
        public async Task<User?> GetByEmailAsync(string email)
        {
            return (await _userRepository.FindAsync(u => u.Email == email)).FirstOrDefault();
        }

    }
}
