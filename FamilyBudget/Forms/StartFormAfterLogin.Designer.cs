namespace FamilyBudget.UI.Forms
{
    partial class StartFormAfterLogin
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
        /// private System.ComponentModel.IContainer components = null;
        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelCenter;
        private Label labelNavTitle;
        private Button buttonFamily;
        private Button buttonIncome;
        private Button buttonGoal;
        private Label labelWelcome;
        private Label labelDesc;
        private Roundedbutton buttonProfile;
        private Button buttonExpenses;
        private Button buttonBudget;
        private Panel panelLine;
        private Label labelBenefits;
        private Panel panelRightShadow;
        private Panel panelLeftShadow;
        private Button buttonLogout;
        private Panel panelDropdownProfile;

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
            panelRight = new Panel();
            buttonProfile = new Roundedbutton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonProfileName = new Button();
            buttonProfileSettings = new Button();
            buttonProfileLogout = new Button();
            panelCenter = new Panel();
            labelWelcome = new Label();
            labelDesc = new Label();
            labelBenefits = new Label();
            panelRightShadow = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelLeftShadow = new Panel();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panelCenter.SuspendLayout();
            panelRightShadow.SuspendLayout();
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
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(buttonProfile);
            panelRight.Controls.Add(flowLayoutPanel2);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(951, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(249, 700);
            panelRight.TabIndex = 1;
            panelRight.Paint += panelRight_Paint;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.FromArgb(100, 88, 255);
            buttonProfile.Cursor = Cursors.Hand;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonProfile.ForeColor = Color.White;
            buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProfile.Location = new Point(30, 95);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(180, 50);
            buttonProfile.TabIndex = 0;
            buttonProfile.Text = "Профиль";
            buttonProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += ButtonProfile_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(100, 88, 255);
            flowLayoutPanel2.Controls.Add(buttonProfileName);
            flowLayoutPanel2.Controls.Add(buttonProfileSettings);
            flowLayoutPanel2.Controls.Add(buttonProfileLogout);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(30, 142);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(180, 135);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.WrapContents = false;
            // 
            // buttonProfileName
            // 
            buttonProfileName.BackColor = Color.FromArgb(128, 128, 255);
            buttonProfileName.Enabled = false;
            buttonProfileName.FlatAppearance.BorderSize = 0;
            buttonProfileName.FlatStyle = FlatStyle.Flat;
            buttonProfileName.ForeColor = Color.White;
            buttonProfileName.Location = new Point(0, 0);
            buttonProfileName.Margin = new Padding(0);
            buttonProfileName.Name = "buttonProfileName";
            buttonProfileName.Size = new Size(180, 45);
            buttonProfileName.TabIndex = 0;
            buttonProfileName.Text = "Иван Иванов";
            buttonProfileName.UseVisualStyleBackColor = false;
            // 
            // buttonProfileSettings
            // 
            buttonProfileSettings.BackColor = Color.FromArgb(128, 128, 255);
            buttonProfileSettings.FlatAppearance.BorderSize = 0;
            buttonProfileSettings.FlatStyle = FlatStyle.Flat;
            buttonProfileSettings.ForeColor = Color.White;
            buttonProfileSettings.Location = new Point(0, 45);
            buttonProfileSettings.Margin = new Padding(0);
            buttonProfileSettings.Name = "buttonProfileSettings";
            buttonProfileSettings.Size = new Size(180, 45);
            buttonProfileSettings.TabIndex = 1;
            buttonProfileSettings.Text = "Настройки";
            buttonProfileSettings.UseVisualStyleBackColor = false;
            buttonProfileSettings.Click += ButtonSettings_Click;
            // 
            // buttonProfileLogout
            // 
            buttonProfileLogout.BackColor = Color.FromArgb(128, 128, 255);
            buttonProfileLogout.FlatAppearance.BorderSize = 0;
            buttonProfileLogout.FlatStyle = FlatStyle.Flat;
            buttonProfileLogout.ForeColor = Color.White;
            buttonProfileLogout.Location = new Point(0, 90);
            buttonProfileLogout.Margin = new Padding(0);
            buttonProfileLogout.Name = "buttonProfileLogout";
            buttonProfileLogout.Size = new Size(180, 45);
            buttonProfileLogout.TabIndex = 2;
            buttonProfileLogout.Text = "Выйти";
            buttonProfileLogout.UseVisualStyleBackColor = false;
            buttonProfileLogout.Click += ButtonLogout_Click;
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
            panelRightShadow.Controls.Add(flowLayoutPanel1);
            panelRightShadow.Dock = DockStyle.Right;
            panelRightShadow.Location = new Point(946, 0);
            panelRightShadow.Name = "panelRightShadow";
            panelRightShadow.Size = new Size(5, 700);
            panelRightShadow.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(35, 142);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(180, 133);
            flowLayoutPanel1.TabIndex = 1;
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
            // StartFormAfterLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelRightShadow);
            Controls.Add(panelLeftShadow);
            Controls.Add(panelCenter);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Name = "StartFormAfterLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FamilyBudget";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            panelRightShadow.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonProfileName;
        private Button buttonProfileSettings;
        private Button buttonProfileLogout;
        private bool isDropdownVisible = false;
    }
}