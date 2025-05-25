namespace FamilyBudget.UI.Forms
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelCenter;
        private Label labelNavTitle;
        private Button buttonFamily;
        private Button buttonIncome;
        private Button buttonGoal;
        private Label labelWelcome;
        private Label labelDesc;
        private Button buttonLogin;
        private Button buttonRegister;
        private Label labelAuthTitle;

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
            panelLeft = new Panel();
            buttonExpenses = new Button();
            buttonBudget = new Button();
            buttonGoal = new Button();
            buttonIncome = new Button();
            buttonFamily = new Button();
            labelNavTitle = new Label();
            panelLine = new Panel();
            pictureLogo = new PictureBox();
            panelRight = new Panel();
            labelAuthTitle = new Label();
            buttonLogin = new Button();
            buttonRegister = new Button();
            panelCenter = new Panel();
            labelWelcome = new Label();
            labelDesc = new Label();
            labelBenefits = new Label();
            panelRightShadow = new Panel();
            panelLeftShadow = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panelRight.SuspendLayout();
            panelCenter.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(100, 88, 255);
            panelLeft.Controls.Add(buttonExpenses);
            panelLeft.Controls.Add(buttonBudget);
            panelLeft.Controls.Add(buttonGoal);
            panelLeft.Controls.Add(buttonIncome);
            panelLeft.Controls.Add(buttonFamily);
            panelLeft.Controls.Add(labelNavTitle);
            panelLeft.Controls.Add(panelLine);
            panelLeft.Controls.Add(pictureLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 700);
            panelLeft.TabIndex = 0;
            // 
            // buttonExpenses
            // 
            buttonExpenses.FlatAppearance.BorderSize = 0;
            buttonExpenses.FlatStyle = FlatStyle.Flat;
            buttonExpenses.Font = new Font("Segoe UI", 10F);
            buttonExpenses.ForeColor = Color.White;
            buttonExpenses.Location = new Point(20, 250);
            buttonExpenses.Name = "buttonExpenses";
            buttonExpenses.Size = new Size(160, 40);
            buttonExpenses.TabIndex = 0;
            buttonExpenses.Text = "Траты";
            // 
            // buttonBudget
            // 
            buttonBudget.FlatAppearance.BorderSize = 0;
            buttonBudget.FlatStyle = FlatStyle.Flat;
            buttonBudget.Font = new Font("Segoe UI", 10F);
            buttonBudget.ForeColor = Color.White;
            buttonBudget.Location = new Point(20, 300);
            buttonBudget.Name = "buttonBudget";
            buttonBudget.Size = new Size(160, 40);
            buttonBudget.TabIndex = 1;
            buttonBudget.Text = "Бюджет";
            // 
            // buttonGoal
            // 
            buttonGoal.FlatAppearance.BorderSize = 0;
            buttonGoal.FlatStyle = FlatStyle.Flat;
            buttonGoal.Font = new Font("Segoe UI", 10F);
            buttonGoal.ForeColor = Color.White;
            buttonGoal.Location = new Point(20, 200);
            buttonGoal.Name = "buttonGoal";
            buttonGoal.Size = new Size(160, 40);
            buttonGoal.TabIndex = 0;
            buttonGoal.Text = "Цель";
            buttonGoal.UseVisualStyleBackColor = true;
            // 
            // buttonIncome
            // 
            buttonIncome.FlatAppearance.BorderSize = 0;
            buttonIncome.FlatStyle = FlatStyle.Flat;
            buttonIncome.Font = new Font("Segoe UI", 10F);
            buttonIncome.ForeColor = Color.White;
            buttonIncome.Location = new Point(20, 150);
            buttonIncome.Name = "buttonIncome";
            buttonIncome.Size = new Size(160, 40);
            buttonIncome.TabIndex = 1;
            buttonIncome.Text = "Доходы";
            buttonIncome.UseVisualStyleBackColor = true;
            // 
            // buttonFamily
            // 
            buttonFamily.FlatAppearance.BorderSize = 0;
            buttonFamily.FlatStyle = FlatStyle.Flat;
            buttonFamily.Font = new Font("Segoe UI", 10F);
            buttonFamily.ForeColor = Color.White;
            buttonFamily.Location = new Point(20, 100);
            buttonFamily.Name = "buttonFamily";
            buttonFamily.Size = new Size(160, 40);
            buttonFamily.TabIndex = 2;
            buttonFamily.Text = "Семья";
            buttonFamily.UseVisualStyleBackColor = true;
            buttonFamily.Click += buttonFamily_Click;
            // 
            // labelNavTitle
            // 
            labelNavTitle.AutoSize = true;
            labelNavTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelNavTitle.ForeColor = Color.White;
            labelNavTitle.Location = new Point(20, 50);
            labelNavTitle.Name = "labelNavTitle";
            labelNavTitle.Size = new Size(169, 32);
            labelNavTitle.TabIndex = 3;
            labelNavTitle.Text = "FamilyBudget";
            // 
            // panelLine
            // 
            panelLine.BackColor = Color.White;
            panelLine.Location = new Point(20, 90);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(160, 2);
            panelLine.TabIndex = 4;
            // 
            // pictureLogo
            // 
            pictureLogo.Location = new Point(20, 600);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(160, 80);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 5;
            pictureLogo.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(labelAuthTitle);
            panelRight.Controls.Add(buttonLogin);
            panelRight.Controls.Add(buttonRegister);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(951, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(249, 700);
            panelRight.TabIndex = 1;
            // 
            // labelAuthTitle
            // 
            labelAuthTitle.AutoSize = true;
            labelAuthTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAuthTitle.ForeColor = Color.FromArgb(100, 88, 255);
            labelAuthTitle.Location = new Point(20, 100);
            labelAuthTitle.Name = "labelAuthTitle";
            labelAuthTitle.Size = new Size(208, 28);
            labelAuthTitle.TabIndex = 0;
            labelAuthTitle.Text = "Добро пожаловать!";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(100, 88, 255);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10F);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(46, 161);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 40);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Авторизация";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.FlatAppearance.BorderColor = Color.FromArgb(100, 88, 255);
            buttonRegister.FlatAppearance.BorderSize = 2;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 10F);
            buttonRegister.ForeColor = Color.FromArgb(100, 88, 255);
            buttonRegister.Location = new Point(46, 219);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(150, 40);
            buttonRegister.TabIndex = 2;
            buttonRegister.Text = "Регистрация";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += ButtonRegister_Click;
            // 
            // panelCenter
            // 
            panelCenter.BackColor = Color.White;
            panelCenter.Controls.Add(labelWelcome);
            panelCenter.Controls.Add(labelDesc);
            panelCenter.Controls.Add(labelBenefits);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(200, 0);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(751, 700);
            panelCenter.TabIndex = 2;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.FromArgb(100, 88, 255);
            labelWelcome.Location = new Point(100, 50);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(626, 37);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Управляй семейным бюджетом эффективно!";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Segoe UI", 11F);
            labelDesc.ForeColor = Color.Gray;
            labelDesc.Location = new Point(100, 115);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(600, 25);
            labelDesc.TabIndex = 1;
            labelDesc.Text = "Следи за доходами, трать разумно и достигай целей вместе с нами.";
            // 
            // labelBenefits
            // 
            labelBenefits.AutoSize = true;
            labelBenefits.Font = new Font("Segoe UI", 10F);
            labelBenefits.ForeColor = Color.DimGray;
            labelBenefits.Location = new Point(100, 180);
            labelBenefits.Name = "labelBenefits";
            labelBenefits.Size = new Size(309, 69);
            labelBenefits.TabIndex = 2;
            labelBenefits.Text = "✓ Анализ расходов и доходов\n✓ Совместный доступ для всей семьи\n✓ Удобные цели и отчёты";
            // 
            // panelRightShadow
            // 
            panelRightShadow.BackColor = Color.FromArgb(50, 50, 50, 50);
            panelRightShadow.Dock = DockStyle.Right;
            panelRightShadow.Location = new Point(946, 0);
            panelRightShadow.Name = "panelRightShadow";
            panelRightShadow.Size = new Size(5, 700);
            panelRightShadow.TabIndex = 0;
            // 
            // panelLeftShadow
            // 
            panelLeftShadow.BackColor = Color.FromArgb(50, 50, 50, 50);
            panelLeftShadow.Dock = DockStyle.Left;
            panelLeftShadow.Location = new Point(200, 0);
            panelLeftShadow.Name = "panelLeftShadow";
            panelLeftShadow.Size = new Size(5, 700);
            panelLeftShadow.TabIndex = 1;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelRightShadow);
            Controls.Add(panelLeftShadow);
            Controls.Add(panelCenter);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FamilyBudget";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonExpenses;
        private Button buttonBudget;
        private Panel panelLine;
        private PictureBox pictureLogo;
        private Label labelBenefits;
        private Panel panelRightShadow;
        private Panel panelLeftShadow;
    }
}