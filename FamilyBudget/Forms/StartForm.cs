using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.Infrastructure.Services;
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
    public partial class StartForm : Form
    {
        private readonly INavigationService _navigationService;
        private readonly IServiceProvider _serviceProvider;

        public StartForm(IServiceProvider serviceProvider, INavigationService navigationService)
        {
            _serviceProvider = serviceProvider;
            _navigationService = navigationService;
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
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
                }

            } while (result == DialogResult.Retry);
        }
        private void buttonFamily_Click(object sender, EventArgs e)
        {
            _navigationService.ClickFamilyButton(this, panelCenter);
        }
    }
}
