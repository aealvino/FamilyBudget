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
    public partial class StartFormAfterLogin : Form
    {
        private readonly INavigationService _navigationService;
        public StartFormAfterLogin(INavigationService navigationService)
        {
            _navigationService = navigationService;
            InitializeComponent();
        }
        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            isDropdownVisible = !isDropdownVisible;
            flowLayoutPanel2.Visible = isDropdownVisible;
        }
        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            // Реализация выхода
            System.Windows.Forms.Application.Exit();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Настройки профиля (в разработке)");
        }

        // Можно также подписать на другие кнопки:
        private void ButtonSettingsDropdown_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открыть настройки профиля...");
        }

        private void ButtonLogoutDropdown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonFamily_Click(object sender, EventArgs e)
        {
            _navigationService.ClickFamilyButton(this, panelCenter);
        }
    }
}
