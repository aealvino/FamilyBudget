using FamilyBudget.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FamilyBudget.UI.Forms
{
    public partial class CreateFamilyForm : Form
    {
        public string FamilyName => textBoxFamilyName.Text.Trim();
        private readonly User _currentUser;

        public CreateFamilyForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FamilyName))
            {
                MessageBox.Show("Введите название семьи.");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
