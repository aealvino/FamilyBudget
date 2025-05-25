using FamilyBudget.Application.DTOs;
using FamilyBudget.ApplicationCore.DTOs;
using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.Domain.Interfaces;
using FamilyBudget.Infrastructure.Services;
using FluentValidation;
using MapsterMapper;
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
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;
        public LoginForm(IAuthService authService, IMapper mapper, IServiceProvider serviceProvider)
        {
            _authService = authService;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationTitle_Click(object sender, EventArgs e)
        {

        }
        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // Специальный флаг: "перейти к регистрации"
            this.Close();
        }




        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var loginDto = new UserLoginDTO
            {
                Email = Email_textBox.Text,
                PasswordHash = Password_textbox.Text
            };

            var validator = _serviceProvider.GetRequiredService<IValidator<UserLoginDTO>>();
            var validationResult = validator.Validate(loginDto);

            if (!validationResult.IsValid)
            {
                string errorMessages = string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(errorMessages, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = await _authService.LoginUser(loginDto);

            if (user != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignInLabel_MouseEnter(object sender, EventArgs e)
        {
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point, 204);
        }
        private void SignInLabel_MouseLeave(object sender, EventArgs e)
        {
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
        }

        private void Password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationTitle_Click_1(object sender, EventArgs e)
        {

        }
    }
}
