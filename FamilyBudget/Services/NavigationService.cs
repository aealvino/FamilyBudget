using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.UI.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Infrastructure.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserSessionService _userSession;
        public NavigationService(IServiceProvider serviceProvider, IUserSessionService userSession)
        {
            _serviceProvider = serviceProvider;
            _userSession = userSession;
        }
        public void ClickFamilyButton(Form parentForm, Control container = null)
        {
            if (!_userSession.IsLoggedIn)
            {
                MessageBox.Show(parentForm, "Пожалуйста, авторизуйтесь для доступа к разделу 'Семья'", "Доступ запрещён", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var familyForm = _serviceProvider.GetRequiredService<FamilyForm>();
            familyForm.TopLevel = false;
            familyForm.FormBorderStyle = FormBorderStyle.None;
            familyForm.Dock = DockStyle.Fill;

            if (container != null)
            {
                container.Controls.Clear();
                container.Controls.Add(familyForm);
                familyForm.Show();
            }
            else
            {
                familyForm.Show();
            }
        }
    }
}
