namespace FamilyBudget.UI.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegistrationTitle = new Label();
            LoginButton = new Roundedbutton();
            SignInLabel = new Label();
            Password_textbox = new RoundedTextBox();
            Email_textBox = new RoundedTextBox();
            shadowPanel = new Panel();
            lineEmail = new Panel();
            linePassword = new Panel();
            SuspendLayout();
            // 
            // RegistrationTitle
            // 
            RegistrationTitle.AutoSize = true;
            RegistrationTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            RegistrationTitle.ForeColor = Color.FromArgb(100, 88, 255);
            RegistrationTitle.Location = new Point(160, 40);
            RegistrationTitle.Name = "RegistrationTitle";
            RegistrationTitle.Size = new Size(103, 46);
            RegistrationTitle.TabIndex = 1;
            RegistrationTitle.Text = "Вход";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(100, 88, 255);
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(47, 260);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(380, 45);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Cursor = Cursors.Hand;
            SignInLabel.Font = new Font("Segoe UI", 10F);
            SignInLabel.ForeColor = Color.FromArgb(100, 88, 255);
            SignInLabel.Location = new Point(100, 330);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(274, 23);
            SignInLabel.TabIndex = 7;
            SignInLabel.Text = "Нет аккаунта? Зарегистрируйтесь";
            SignInLabel.Click += SignUpLabel_Click;
            SignInLabel.MouseEnter += SignInLabel_MouseEnter;
            SignInLabel.MouseLeave += SignInLabel_MouseLeave;
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = Color.White;
            Password_textbox.BorderStyle = BorderStyle.None;
            Password_textbox.Font = new Font("Segoe UI", 12F);
            Password_textbox.ForeColor = Color.Gray;
            Password_textbox.Location = new Point(47, 190);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '•';
            Password_textbox.PlaceholderText = "Пароль";
            Password_textbox.Size = new Size(380, 27);
            Password_textbox.TabIndex = 4;
            Password_textbox.TextChanged += Password_textbox_TextChanged;
            // 
            // Email_textBox
            // 
            Email_textBox.BackColor = Color.White;
            Email_textBox.BorderStyle = BorderStyle.None;
            Email_textBox.Font = new Font("Segoe UI", 12F);
            Email_textBox.ForeColor = Color.Gray;
            Email_textBox.Location = new Point(47, 130);
            Email_textBox.Name = "Email_textBox";
            Email_textBox.PlaceholderText = "Email";
            Email_textBox.Size = new Size(380, 27);
            Email_textBox.TabIndex = 2;
            // 
            // shadowPanel
            // 
            shadowPanel.BackColor = Color.FromArgb(50, 50, 50, 50);
            shadowPanel.Dock = DockStyle.Right;
            shadowPanel.Location = new Point(468, 0);
            shadowPanel.Name = "shadowPanel";
            shadowPanel.Size = new Size(6, 628);
            shadowPanel.TabIndex = 0;
            // 
            // lineEmail
            // 
            lineEmail.BackColor = Color.LightGray;
            lineEmail.Location = new Point(47, 160);
            lineEmail.Name = "lineEmail";
            lineEmail.Size = new Size(380, 1);
            lineEmail.TabIndex = 3;
            // 
            // linePassword
            // 
            linePassword.BackColor = Color.LightGray;
            linePassword.Location = new Point(47, 220);
            linePassword.Name = "linePassword";
            linePassword.Size = new Size(380, 1);
            linePassword.TabIndex = 5;
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(474, 628);
            Controls.Add(shadowPanel);
            Controls.Add(RegistrationTitle);
            Controls.Add(Email_textBox);
            Controls.Add(lineEmail);
            Controls.Add(Password_textbox);
            Controls.Add(linePassword);
            Controls.Add(LoginButton);
            Controls.Add(SignInLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label RegistrationTitle;
        private Roundedbutton LoginButton;
        private Label SignInLabel;
        private RoundedTextBox Password_textbox;
        private RoundedTextBox Email_textBox;
        private Panel shadowPanel;
        private Panel lineEmail;
        private Panel linePassword;
    }
}