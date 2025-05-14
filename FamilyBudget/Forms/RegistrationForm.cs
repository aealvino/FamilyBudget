using FamilyBudget.Application.DTOs;
using FamilyBudget.Domain.Interfaces;
using MapsterMapper;
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

        public RegistrationForm(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            SetPlaceholder(Name_textbox, "Name");
            SetPlaceholder(Secondname_textbox, "Second name");
            SetPlaceholder(Email_textBox, "Email address");
            SetPlaceholder(Password_textbox, "Password");
            SetPlaceholder(confirmpassword_textbox, "Confirm password");

            Name_textbox.Enter += (s, e) => RemovePlaceholder(Name_textbox, "Name");
            Name_textbox.Leave += (s, e) => SetPlaceholder(Name_textbox, "Name");

            Secondname_textbox.Enter += (s, e) => RemovePlaceholder(Secondname_textbox, "Second name");
            Secondname_textbox.Leave += (s, e) => SetPlaceholder(Secondname_textbox, "Second name");

            Email_textBox.Enter += (s, e) => RemovePlaceholder(Email_textBox, "Email address");
            Email_textBox.Leave += (s, e) => SetPlaceholder(Email_textBox, "Email address");

            Password_textbox.Enter += (s, e) => RemovePlaceholder(Password_textbox, "Password");
            Password_textbox.Leave += (s, e) => SetPlaceholder(Password_textbox, "Password");

            confirmpassword_textbox.Enter += (s, e) => RemovePlaceholder(confirmpassword_textbox, "Confirm password");
            confirmpassword_textbox.Leave += (s, e) => SetPlaceholder(confirmpassword_textbox, "Confirm password");
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

        private async void CreateAccountButton_Click(object sender, EventArgs e)
        {
            var userDto = new UserRegisterDto
            {
                Name = Name_textbox.Text,
                SecondName = Secondname_textbox.Text,
                Email = Email_textBox.Text,
                PasswordHash = Password_textbox.Text,
                DateOfBirth = null
            };

            var result = await _userService.RegisterAsync(userDto);
        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {

        }
        private void SignInLabel_MouseEnter(object sender, EventArgs e)
        {
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point, 204);
        }
        private void SignInLabel_MouseLeave(object sender, EventArgs e)
        {
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
    }
}