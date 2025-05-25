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
    public partial class AddFamilyMemberForm: Form
    {
        public AddFamilyMemberForm()
        {
            InitializeComponent();
            buttonAdd.Click += ButtonAdd_Click;
            buttonCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Введите email.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
