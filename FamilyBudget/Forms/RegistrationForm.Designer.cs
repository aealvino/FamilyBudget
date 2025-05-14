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
            SuspendLayout();
            // 
            // RegistrationTitle
            // 
            RegistrationTitle.AutoSize = true;
            RegistrationTitle.BackColor = Color.BlanchedAlmond;
            RegistrationTitle.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            RegistrationTitle.ForeColor = Color.FromArgb(64, 0, 0);
            RegistrationTitle.Location = new Point(139, 22);
            RegistrationTitle.Name = "RegistrationTitle";
            RegistrationTitle.Size = new Size(188, 46);
            RegistrationTitle.TabIndex = 3;
            RegistrationTitle.Text = "Get started";
            RegistrationTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Name_textbox
            // 
            Name_textbox.BackColor = Color.Linen;
            Name_textbox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name_textbox.ForeColor = Color.Gray;
            Name_textbox.Location = new Point(37, 110);
            Name_textbox.Name = "Name_textbox";
            Name_textbox.PlaceholderText = "Name";
            Name_textbox.Size = new Size(392, 32);
            Name_textbox.TabIndex = 4;
            Name_textbox.TextChanged += Name_textbox_TextChanged;
            // 
            // Secondname_textbox
            // 
            Secondname_textbox.BackColor = Color.Linen;
            Secondname_textbox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Secondname_textbox.ForeColor = Color.Gray;
            Secondname_textbox.Location = new Point(37, 161);
            Secondname_textbox.Name = "Secondname_textbox";
            Secondname_textbox.PlaceholderText = "Second name";
            Secondname_textbox.Size = new Size(392, 32);
            Secondname_textbox.TabIndex = 5;
            Secondname_textbox.TextChanged += textBox1_TextChanged;
            // 
            // Email_textBox
            // 
            Email_textBox.BackColor = Color.Linen;
            Email_textBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Email_textBox.ForeColor = Color.Gray;
            Email_textBox.Location = new Point(37, 215);
            Email_textBox.Name = "Email_textBox";
            Email_textBox.PlaceholderText = "Email Address";
            Email_textBox.Size = new Size(392, 32);
            Email_textBox.TabIndex = 6;
            // 
            // Password_textbox
            // 
            Password_textbox.BackColor = Color.Linen;
            Password_textbox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_textbox.ForeColor = Color.Gray;
            Password_textbox.Location = new Point(37, 276);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '•';
            Password_textbox.PlaceholderText = "Password";
            Password_textbox.Size = new Size(392, 32);
            Password_textbox.TabIndex = 7;
            Password_textbox.TextChanged += textBox3_TextChanged;
            // 
            // confirmpassword_textbox
            // 
            confirmpassword_textbox.BackColor = Color.Linen;
            confirmpassword_textbox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            confirmpassword_textbox.ForeColor = Color.Gray;
            confirmpassword_textbox.Location = new Point(37, 331);
            confirmpassword_textbox.Name = "confirmpassword_textbox";
            confirmpassword_textbox.PasswordChar = '•';
            confirmpassword_textbox.PlaceholderText = "Confirm password";
            confirmpassword_textbox.Size = new Size(392, 32);
            confirmpassword_textbox.TabIndex = 8;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.BackColor = Color.Chocolate;
            CreateAccountButton.FlatAppearance.BorderSize = 0;
            CreateAccountButton.FlatStyle = FlatStyle.Flat;
            CreateAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateAccountButton.ForeColor = Color.White;
            CreateAccountButton.Location = new Point(37, 428);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(392, 45);
            CreateAccountButton.TabIndex = 9;
            CreateAccountButton.Text = "Create Account";
            CreateAccountButton.UseVisualStyleBackColor = false;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Cursor = Cursors.Hand;
            SignInLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SignInLabel.ForeColor = Color.FromArgb(41, 128, 185);
            SignInLabel.Location = new Point(98, 476);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(263, 23);
            SignInLabel.TabIndex = 10;
            SignInLabel.Text = "Already have an account? Sign in";
            SignInLabel.Click += SignInLabel_Click;
            SignInLabel.MouseEnter += SignInLabel_MouseEnter;
            SignInLabel.MouseLeave += SignInLabel_MouseLeave;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(474, 628);
            Controls.Add(confirmpassword_textbox);
            Controls.Add(Password_textbox);
            Controls.Add(Email_textBox);
            Controls.Add(Secondname_textbox);
            Controls.Add(Name_textbox);
            Controls.Add(RegistrationTitle);
            Controls.Add(CreateAccountButton);
            Controls.Add(SignInLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
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
    }
}