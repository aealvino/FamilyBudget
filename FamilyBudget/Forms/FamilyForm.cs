using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget.UI.Forms
{
    public partial class FamilyForm : Form
    {
        private readonly IFamilyService _familyService;
        private readonly IUserSessionService _userSessionService;
        private readonly IUserService _userService;
        public FamilyForm(IFamilyService familyService, IUserSessionService userSessionService, IUserService userService)
        {
            InitializeComponent();
            _familyService = familyService;
            _userSessionService = userSessionService;
            _userService = userService;
        }
        private async void ButtonLoadFamilies_Click(object? sender, EventArgs e)
        {
            await LoadFamiliesAsync();
        }
        private async Task LoadFamiliesAsync()
        {
            var userId = _userSessionService.UserId;

            if (userId == null)
            {
                MessageBox.Show("Пользователь не авторизован.");
                return;
            }

            var families = await _familyService.GetFamiliesForUserAsync(userId.Value);

            dataGridViewFamily.DataSource = families.Select(f => new
            {
                f.Id,
                f.Name,
                Created = f.CreatedDate?.ToString("dd.MM.yyyy") ?? "-"
            }).ToList();
        }
        private async void ButtonShowMembers_Click(object? sender, EventArgs e)
        {
            await LoadFamilyMembersAsync();
        }

        private async Task LoadFamilyMembersAsync()
        {
            var userId = _userSessionService.UserId;
            if (userId == null)
            {
                MessageBox.Show("Пользователь не авторизован.");
                return;
            }

            if (dataGridViewFamily.CurrentRow == null)
            {
                MessageBox.Show("Выберите семью из списка.");
                return;
            }

            // Получение выбранного ID семьи
            var selectedFamilyId = Convert.ToInt32(dataGridViewFamily.CurrentRow.Cells["Id"].Value);

            // Получение пользователей семьи
            var users = await _familyService.GetUsersInFamilyAsync(selectedFamilyId);
            if (users == null || !users.Any())
            {
                MessageBox.Show("Нет участников в выбранной семье.");
                return;
            }

            // Отображение участников
            var members = users.Select(u => new
            {
                Имя = u.Name,
                Фамилия = u.SecondName,
                Почта = u.Email,
                Баланс = u.Balance
            }).ToList();

            dataGridViewFamily.DataSource = members;
        }

        private async void buttonCreateFamily_Click(object? sender, EventArgs e)
        {
            var userId = _userSessionService.UserId;
            if (userId == null)
            {
                MessageBox.Show("Пользователь не авторизован.");
                return;
            }

            var user = await _userService.GetByIdAsync(userId.Value);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден.");
                return;
            }

            var createForm = new CreateFamilyForm(user);
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                await _familyService.CreateFamilyAsync(createForm.FamilyName, user.Id);
                await LoadFamiliesAsync(); // Обновляем список семей
            }
        }

        private async void buttonDeleteFamily_Click(object sender, EventArgs e)
        {
            if (dataGridViewFamily.CurrentRow == null)
            {
                MessageBox.Show("Выберите семью для удаления.");
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить эту семью?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            var selectedFamilyId = Convert.ToInt32(dataGridViewFamily.CurrentRow.Cells["Id"].Value);

            try
            {
                await _familyService.DeleteFamilyAsync(selectedFamilyId);
                await LoadFamiliesAsync(); // Обновим список
                MessageBox.Show("Семья успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }
    }
}
