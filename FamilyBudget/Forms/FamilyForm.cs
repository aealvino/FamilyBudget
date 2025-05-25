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
                f.CreatedByUserId,
                Created = f.CreatedDate?.ToString("dd.MM.yyyy") ?? "-"
            }).ToList();

            dataGridViewFamily.ClearSelection();
            buttonDeleteMembers.Visible = false;
            await CheckUserPermissionsAsync(); // <= Добавьте это
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
                UserId = u.Id,  // Добавляем для внутреннего использования
                Имя = u.Name,
                Фамилия = u.SecondName,
                Почта = u.Email,
                Баланс = u.Balance
            }).ToList();

            dataGridViewFamily.DataSource = members;
            buttonDeleteMembers.Visible = true;
            // Скрываем колонку UserId, чтобы она не отображалась пользователю, но была в таблице
            if (dataGridViewFamily.Columns["UserId"] != null)
                dataGridViewFamily.Columns["UserId"].Visible = false;

            // Настройка выбора строк (можно добавить один раз при инициализации)
            dataGridViewFamily.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFamily.MultiSelect = true;
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
                await LoadFamiliesAsync();
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

        private async Task CheckUserPermissionsAsync()
        {
            var userId = _userSessionService.UserId;
            if (userId == null)
            {
                buttonDeleteFamily.Visible = false;
                return;
            }

            var user = await _userService.GetByIdAsync(userId.Value);
            if (user == null)
            {
                buttonDeleteFamily.Visible = false;
                return;
            }

            // По умолчанию скрываем кнопку
            buttonDeleteFamily.Visible = false;

            if (user.Role?.Name == "Админ")
            {
                buttonDeleteFamily.Visible = true;
                return;
            }

            // Если пользователь — владелец семьи
            if (dataGridViewFamily.CurrentRow != null &&
                dataGridViewFamily.Columns.Contains("CreatedByUserId"))
            {
                var createdByUserId = Convert.ToInt32(dataGridViewFamily.CurrentRow.Cells["CreatedByUserId"].Value);
                if (createdByUserId == user.Id)
                {
                    buttonDeleteFamily.Visible = true;
                }
            }
        }

        private async void DataGridViewFamily_SelectionChanged(object? sender, EventArgs e)
        {
            await CheckUserPermissionsAsync();
        }

        private async void buttonDeleteMembers_Click(object sender, EventArgs e)
        {
            if (dataGridViewFamily.Rows.Count == 0)
            {
                MessageBox.Show("Нет членов для удаления.");
                return;
            }

            var selectedRows = dataGridViewFamily.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одного члена семьи для удаления.");
                return;
            }

            var confirm = MessageBox.Show("Вы уверены, что хотите удалить выбранных членов семьи?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            if (dataGridViewFamily.CurrentRow == null)
            {
                MessageBox.Show("Ошибка: не выбрана семья.");
                return;
            }

            var selectedFamilyId = Convert.ToInt32(dataGridViewFamily.CurrentRow.Cells["Id"]?.Value ?? 0);

            // Получаем выбранные Id пользователей из отображаемой таблицы участников
            var userIdsToDelete = new List<int>();

            // Поскольку в таблице участников сейчас нет Id пользователей (в твоём коде ты выводишь только имя, фамилию, почту, баланс),
            // нужно изменить метод LoadFamilyMembersAsync, чтобы передавать также Id пользователя в datasource.

            foreach (DataGridViewRow row in selectedRows)
            {
                if (row.Cells["UserId"]?.Value is int userId)
                    userIdsToDelete.Add(userId);
            }

            if (!userIdsToDelete.Any())
            {
                MessageBox.Show("Не удалось получить идентификаторы выбранных пользователей.");
                return;
            }

            try
            {
                await _familyService.RemoveUsersFromFamilyAsync(selectedFamilyId, userIdsToDelete);
                MessageBox.Show("Выбранные члены семьи успешно удалены.");

                buttonDeleteMembers.Visible = false;
                await LoadFamilyMembersAsync(); // Обновим таблицу
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }

        private async void buttonAddMember_Click(object sender, EventArgs e)
        {
            if (dataGridViewFamily.CurrentRow == null)
            {
                MessageBox.Show("Выберите семью.");
                return;
            }

            var selectedFamilyId = Convert.ToInt32(dataGridViewFamily.CurrentRow.Cells["Id"].Value);

            var addForm = new AddFamilyMemberForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var email = addForm.Email;

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Email не может быть пустым.");
                    return;
                }

                try
                {
                    var user = await _userService.GetByEmailAsync(email);
                    if (user == null)
                    {
                        MessageBox.Show("Пользователь с таким email не найден.");
                        return;
                    }

                    await _familyService.AddUserToFamilyAsync(selectedFamilyId, user.Id);
                    MessageBox.Show("Пользователь добавлен в семью.");

                    await LoadFamilyMembersAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении: {ex.Message}");
                }
            }
        }

    }
}
