namespace FamilyBudget.UI.Forms
{
    partial class RegistrationForm
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
            Name_textbox = new RoundedTextBox();
            Secondname_textbox = new RoundedTextBox();
            Email_textBox = new RoundedTextBox();
            Password_textbox = new RoundedTextBox();
            confirmpassword_textbox = new RoundedTextBox();
            CreateAccountButton = new Roundedbutton();
            SignInLabel = new Label();
            alreadyHaveAccountLabel = new Label();
            signInLinkLabel = new LinkLabel();
            lineEmail = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // RegistrationTitle
            // 
            RegistrationTitle.AutoSize = true;
            RegistrationTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            RegistrationTitle.ForeColor = Color.FromArgb(100, 88, 255);
            RegistrationTitle.Location = new Point(120, 30);
            RegistrationTitle.Name = "RegistrationTitle";
            RegistrationTitle.Size = new Size(225, 46);
            RegistrationTitle.TabIndex = 0;
            RegistrationTitle.Text = "Регистрация";
            RegistrationTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Name_textbox
            // 
            Name_textbox.BackColor = Color.White;
            Name_textbox.BorderStyle = BorderStyle.None;
            Name_textbox.Font = new Font("Segoe UI", 12F);
            Name_textbox.ForeColor = Color.Black;
            Name_textbox.Location = new Point(37, 110);
            Name_textbox.Name = "Name_textbox";
            Name_textbox.PlaceholderText = "Имя";
            Name_textbox.Size = new Size(392, 27);
            Name_textbox.TabIndex = 1;
            // 
            // Secondname_textbox
            // 
            Secondname_textbox.BackColor = Color.White;
            Secondname_textbox.BorderStyle = BorderStyle.None;
            Secondname_textbox.Font = new Font("Segoe UI", 12F);
            Secondname_textbox.ForeColor = Color.Black;
            Secondname_textbox.Location = new Point(37, 160);
            Secondname_textbox.Name = "Secondname_textbox";
            Secondname_textbox.PlaceholderText = "Фамилия";
            Secondname_textbox.Size = new Size(392, 27);
            Secondname_textbox.TabIndex = 2;
            // 
            // Email_textBox
            // 
            Email_textBox.BackColor = Color.White;
            Email_textBox.BorderStyle = BorderStyle.None;
            Email_textBox.Font = new Font("Segoe UI", 12F);
            Email_textBox.ForeColor = Color.Black;
            Email_textBox.Location = new Point(37, 210);
            Email_textBox.Name = "Email_textBox";
            Email_textBox.PlaceholderText = "Email";
            Email_textBox.Size = new Size(392, 27);
            Email_textBox.TabIndex = 3;
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = Color.White;
            Password_textbox.BorderStyle = BorderStyle.None;
            Password_textbox.Font = new Font("Segoe UI", 12F);
            Password_textbox.ForeColor = Color.Black;
            Password_textbox.Location = new Point(37, 260);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '•';
            Password_textbox.PlaceholderText = "Пароль";
            Password_textbox.Size = new Size(392, 27);
            Password_textbox.TabIndex = 4;
            // 
            // confirmpassword_textbox
            // 
            confirmpassword_textbox.BackColor = Color.White;
            confirmpassword_textbox.BorderStyle = BorderStyle.None;
            confirmpassword_textbox.Font = new Font("Segoe UI", 12F);
            confirmpassword_textbox.ForeColor = Color.Black;
            confirmpassword_textbox.Location = new Point(37, 310);
            confirmpassword_textbox.Name = "confirmpassword_textbox";
            confirmpassword_textbox.PasswordChar = '•';
            confirmpassword_textbox.PlaceholderText = "Повторите пароль";
            confirmpassword_textbox.Size = new Size(392, 27);
            confirmpassword_textbox.TabIndex = 5;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.BackColor = Color.FromArgb(100, 88, 255);
            CreateAccountButton.FlatAppearance.BorderSize = 0;
            CreateAccountButton.FlatStyle = FlatStyle.Flat;
            CreateAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CreateAccountButton.ForeColor = Color.White;
            CreateAccountButton.Location = new Point(37, 390);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(392, 45);
            CreateAccountButton.TabIndex = 6;
            CreateAccountButton.Text = "Создать аккаунт";
            CreateAccountButton.UseVisualStyleBackColor = false;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // SignInLabel
            // 
            SignInLabel.Location = new Point(0, 0);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(100, 23);
            SignInLabel.TabIndex = 7;
            // 
            // alreadyHaveAccountLabel
            // 
            alreadyHaveAccountLabel.AutoSize = true;
            alreadyHaveAccountLabel.Font = new Font("Segoe UI", 10F);
            alreadyHaveAccountLabel.ForeColor = Color.Gray;
            alreadyHaveAccountLabel.Location = new Point(110, 450);
            alreadyHaveAccountLabel.Name = "alreadyHaveAccountLabel";
            alreadyHaveAccountLabel.Size = new Size(152, 23);
            alreadyHaveAccountLabel.TabIndex = 8;
            alreadyHaveAccountLabel.Text = "Уже есть аккаунт?";
            // 
            // signInLinkLabel
            // 
            signInLinkLabel.AutoSize = true;
            signInLinkLabel.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            signInLinkLabel.LinkColor = Color.FromArgb(100, 88, 255);
            signInLinkLabel.Location = new Point(265, 450);
            signInLinkLabel.Name = "signInLinkLabel";
            signInLinkLabel.Size = new Size(75, 23);
            signInLinkLabel.TabIndex = 9;
            signInLinkLabel.TabStop = true;
            signInLinkLabel.Text = "Войдите";
            signInLinkLabel.Click += SignInLabel_Click;
            signInLinkLabel.MouseEnter += SignInLabel_MouseEnter;
            signInLinkLabel.MouseLeave += SignInLabel_MouseLeave;
            // 
            // lineEmail
            // 
            lineEmail.BackColor = Color.LightGray;
            lineEmail.Location = new Point(37, 143);
            lineEmail.Name = "lineEmail";
            lineEmail.Size = new Size(380, 1);
            lineEmail.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(37, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 1);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(37, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 1);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(37, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 1);
            panel3.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(37, 343);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 1);
            panel4.TabIndex = 16;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 628);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lineEmail);
            Controls.Add(RegistrationTitle);
            Controls.Add(Name_textbox);
            Controls.Add(Secondname_textbox);
            Controls.Add(Email_textBox);
            Controls.Add(Password_textbox);
            Controls.Add(confirmpassword_textbox);
            Controls.Add(CreateAccountButton);
            Controls.Add(SignInLabel);
            Controls.Add(alreadyHaveAccountLabel);
            Controls.Add(signInLinkLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion


        private Label RegistrationTitle;
        private Label SignInLabel;
        private RoundedTextBox Name_textbox;
        private RoundedTextBox Secondname_textbox;
        private RoundedTextBox Email_textBox;
        private RoundedTextBox Password_textbox;
        private RoundedTextBox confirmpassword_textbox;
        private Roundedbutton CreateAccountButton;
        private Label alreadyHaveAccountLabel;
        private LinkLabel signInLinkLabel;
        private Panel leftPanel;
        private Label welcomeLabel;
        private Label welcomeDescLabel;
        private Button signInLeftButton;
        private Panel lineEmail;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}