using FamilyBudget.Application.DTOs;
using FamilyBudget.Domain.Interfaces;
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
    public partial class RegistrationForm : Form
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;
        public RegistrationForm(IUserService userService, IMapper mapper, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
            _mapper = mapper;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
        }
        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }
        private async void CreateAccountButton_Click(object sender, EventArgs e)
        {
            var userDto = new UserRegisterDto
            {
                Name = Name_textbox.Text,
                SecondName = Secondname_textbox.Text,
                Email = Email_textBox.Text,
                PasswordHash = Password_textbox.Text,
                ConfirmPasswordHash = confirmpassword_textbox.Text, 
                DateOfBirth = null
            };


            var validator = _serviceProvider.GetRequiredService<IValidator<UserRegisterDto>>();
            var validationResult = validator.Validate(userDto);

            if (!validationResult.IsValid)
            {
                string errorMessages = string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(errorMessages, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = await _userService.RegisterAsync(userDto);
        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; // Специальный флаг: "перейти к логину"
            this.Close();
        }



        private void SignInLabel_MouseEnter(object sender, EventArgs e)
        {
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point, 204);
        }
        private void SignInLabel_MouseLeave(object sender, EventArgs e)
        {
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
        }
    }
}