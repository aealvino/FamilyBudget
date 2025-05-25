using FamilyBudget.ApplicationCore.Enums;
using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.Persistence.Models;
using FamilyBudget.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FamilyBudget.Infrastructure.Services
{
    public class FamilyService : IFamilyService
    {
        private readonly IGenericRepository<Family> _familyRepository;
        private readonly IGenericRepository<User> _userRepository;
        private readonly IGenericRepository<Role> _roleRepository;

        public FamilyService(IGenericRepository<Family> familyRepository, IGenericRepository<User> userRepository, IGenericRepository<Role> roleRepository)
        {
            _familyRepository = familyRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }


        public async Task<IEnumerable<Family>> GetFamiliesForUserAsync(int userId)
        {
            return await _familyRepository.FindWithIncludeAsync(
                f => f.Users.Any(u => u.Id == userId),
                f => f.Users
            );
        }
        public async Task<IEnumerable<User>> GetUsersInFamilyAsync(int familyId)
        {
            var families = await _familyRepository.FindWithIncludeAsync(
                f => f.Id == familyId,
                f => f.Users
            );

            var family = families.FirstOrDefault();
            return family?.Users ?? Enumerable.Empty<User>();
        }
        public async Task CreateFamilyAsync(string name, int userId)
        {
            var existingFamilies = await _familyRepository.FindWithIncludeAsync(
                f => f.Users.Any(u => u.Id == userId),
                f => f.Users);

            if (existingFamilies.Any())
                throw new InvalidOperationException("У пользователя уже есть семья.");

            var user = (await _userRepository.FindAsync(u => u.Id == userId)).FirstOrDefault();
            if (user == null)
                throw new InvalidOperationException("Пользователь не найден.");

            // Получаем роль "Владелец семьи" через enum
            var ownerRole = await GetRoleByNameAsync(UserRole.FamilyOwner);
            if (ownerRole == null)
                throw new InvalidOperationException("Роль 'Владелец семьи' не найдена.");

            var family = new Family
            {
                Name = name,
                CreatedDate = DateTime.UtcNow,
                CreatedByUserId = user.Id,   // <-- вот здесь
                CreatedByUser = user,        // (можно добавить, чтобы навигация тоже была)
                Users = new List<User> { user }
            };


            await _familyRepository.AddAsync(family);

            // Меняем роль пользователя
            user.RoleId = ownerRole.Id;
            _userRepository.Update(user);

            await _familyRepository.SaveChangesAsync();
            await _userRepository.SaveChangesAsync();
        }

        public async Task DeleteFamilyAsync(int familyId)
        {
            var families = await _familyRepository.FindWithIncludeAsync(
                f => f.Id == familyId,
                f => f.Users
            );

            var family = families.FirstOrDefault();
            if (family == null)
                throw new InvalidOperationException("Семья не найдена.");

            // Получаем роль "Пользователь" через enum
            var userRole = await GetRoleByNameAsync(UserRole.User);
            if (userRole == null)
                throw new InvalidOperationException("Роль 'Пользователь' не найдена.");

            foreach (var user in family.Users)
            {
                user.RoleId = userRole.Id;

                // Отсоединяем пользователя от семьи (FamilyId должен быть nullable)
                user.FamilyId = null;

                _userRepository.Update(user);
            }

            _familyRepository.Remove(family);

            await _userRepository.SaveChangesAsync();
            await _familyRepository.SaveChangesAsync();
        }

        // Вспомогательный метод получения роли по enum
        private async Task<Role?> GetRoleByNameAsync(UserRole role)
        {
            var roleName = role switch
            {
                UserRole.Admin => "Админ",
                UserRole.User => "Пользователь",
                UserRole.Guest => "Гость",
                UserRole.FamilyOwner => "Владелец семьи",
                _ => throw new ArgumentOutOfRangeException(nameof(role), "Неизвестная роль")
            };

            var roles = await _roleRepository.FindAsync(r => r.Name == roleName);
            return roles.FirstOrDefault();
        }
        public async Task<bool> IsUserFamilyOwnerAsync(int familyId, int userId)
        {
            var families = await _familyRepository.FindAsync(f => f.Id == familyId && f.CreatedByUserId == userId);
            return families.Any();
        }
        public async Task RemoveUsersFromFamilyAsync(int familyId, List<int> userIds)
        {
            if (userIds == null || !userIds.Any())
                throw new ArgumentException("Список пользователей пуст.");

            // Получаем семью с пользователями
            var families = await _familyRepository.FindWithIncludeAsync(
                f => f.Id == familyId,
                f => f.Users
            );

            var family = families.FirstOrDefault();
            if (family == null)
                throw new InvalidOperationException("Семья не найдена.");

            // Получаем роль "Пользователь"
            var userRole = await GetRoleByNameAsync(UserRole.User);
            if (userRole == null)
                throw new InvalidOperationException("Роль 'Пользователь' не найдена.");

            foreach (var user in family.Users.Where(u => userIds.Contains(u.Id)).ToList())
            {
                user.FamilyId = null;
                user.RoleId = userRole.Id;
                _userRepository.Update(user);
            }

            await _userRepository.SaveChangesAsync();
        }
        public async Task AddUserToFamilyAsync(int familyId, int userId)
        {
            // Получаем семью вместе с пользователями
            var families = await _familyRepository.FindWithIncludeAsync(
                f => f.Id == familyId,
                f => f.Users
            );

            var family = families.FirstOrDefault();
            if (family == null)
                throw new InvalidOperationException("Семья не найдена.");

            // Получаем пользователя
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
                throw new InvalidOperationException("Пользователь не найден.");

            // Проверяем, состоит ли уже пользователь в какой-либо семье
            if (user.FamilyId != null)
                throw new InvalidOperationException("Пользователь уже состоит в другой семье.");

            // Получаем роль "Пользователь"
            var role = await GetRoleByNameAsync(UserRole.User);
            if (role == null)
                throw new InvalidOperationException("Роль 'Пользователь' не найдена.");

            // Присваиваем пользователя семье
            family.Users.Add(user);
            user.FamilyId = family.Id;
            user.RoleId = role.Id;

            _userRepository.Update(user);
            _familyRepository.Update(family);

            await _userRepository.SaveChangesAsync();
            await _familyRepository.SaveChangesAsync();
        }

    }
}
