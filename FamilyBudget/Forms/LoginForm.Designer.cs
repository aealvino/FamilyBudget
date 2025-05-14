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
            CreateAccountButton = new Roundedbutton();
            SignInLabel = new Label();
            Password_textbox = new RoundedTextBox();
            Email_textBox = new RoundedTextBox();
            SuspendLayout();
            // 
            // RegistrationTitle
            // 
            RegistrationTitle.AutoSize = true;
            RegistrationTitle.BackColor = Color.BlanchedAlmond;
            RegistrationTitle.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            RegistrationTitle.ForeColor = Color.FromArgb(64, 0, 0);
            RegistrationTitle.Location = new Point(189, 33);
            RegistrationTitle.Name = "RegistrationTitle";
            RegistrationTitle.Size = new Size(105, 46);
            RegistrationTitle.TabIndex = 11;
            RegistrationTitle.Text = "Login";
            RegistrationTitle.TextAlign = ContentAlignment.MiddleCenter;
            RegistrationTitle.Click += RegistrationTitle_Click;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.BackColor = Color.Chocolate;
            CreateAccountButton.FlatAppearance.BorderSize = 0;
            CreateAccountButton.FlatStyle = FlatStyle.Flat;
            CreateAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateAccountButton.ForeColor = Color.White;
            CreateAccountButton.Location = new Point(47, 274);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(392, 45);
            CreateAccountButton.TabIndex = 17;
            CreateAccountButton.Text = "Login";
            CreateAccountButton.UseVisualStyleBackColor = false;
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Cursor = Cursors.Hand;
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SignInLabel.ForeColor = Color.FromArgb(41, 128, 185);
            SignInLabel.Location = new Point(100, 339);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(273, 23);
            SignInLabel.TabIndex = 18;
            SignInLabel.Text = "Not registered? Create an account";
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = Color.Linen;
            Password_textbox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_textbox.ForeColor = Color.Gray;
            Password_textbox.Location = new Point(47, 188);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '•';
            Password_textbox.PlaceholderText = "Password";
            Password_textbox.Size = new Size(392, 32);
            Password_textbox.TabIndex = 20;
            // 
            // Email_textBox
            // 
            Email_textBox.BackColor = Color.Linen;
            Email_textBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Email_textBox.ForeColor = Color.Gray;
            Email_textBox.Location = new Point(47, 127);
            Email_textBox.Name = "Email_textBox";
            Email_textBox.PlaceholderText = "Email Address";
            Email_textBox.Size = new Size(392, 32);
            Email_textBox.TabIndex = 19;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(474, 628);
            Controls.Add(Password_textbox);
            Controls.Add(Email_textBox);
            Controls.Add(RegistrationTitle);
            Controls.Add(CreateAccountButton);
            Controls.Add(SignInLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label RegistrationTitle;
        private Roundedbutton CreateAccountButton;
        private Label SignInLabel;
        private RoundedTextBox Password_textbox;
        private RoundedTextBox Email_textBox;
    }
}