using FamilyBudget.ApplicationCore.Interfaces;
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
        public FamilyForm(IFamilyService familyService, IUserSessionService userSessionService)
        {
            InitializeComponent();
            _familyService = familyService;
            _userSessionService = userSessionService;
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

            var families = await _familyService.GetFamiliesForUserAsync(userId.Value);
            var currentFamily = families.FirstOrDefault();

            if (currentFamily == null || currentFamily.Users == null)
            {
                MessageBox.Show("Семья не найдена.");
                return;
            }

            var members = currentFamily.Users.Select(u => new
            {
                Имя = u.Name,
                Фамилия = u.SecondName,
                Почта = u.Email,
                Баланс = u.Balance
            }).ToList();

            dataGridViewFamily.DataSource = members;
        }

    }
}
