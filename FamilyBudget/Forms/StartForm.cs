using Microsoft.Extensions.DependencyInjection;
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
    public partial class StartForm: Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Form? _activeModalForm;

        public StartForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            ShowAuthFlow(startWithLogin: true);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            ShowAuthFlow(startWithLogin: false);
        }
        private void ShowAuthFlow(bool startWithLogin)
        {
            DialogResult result;
            Form? authForm;

            do
            {
                authForm = startWithLogin
                    ? _serviceProvider.GetRequiredService<LoginForm>()
                    : _serviceProvider.GetRequiredService<RegistrationForm>();

                result = authForm.ShowDialog(this);

                if (result == DialogResult.Retry)
                {
                    startWithLogin = !startWithLogin;
                }

                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Закрываем StartForm
                    break;
                }

            } while (result == DialogResult.Retry);
        }

    }
}
