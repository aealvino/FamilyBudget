namespace FamilyBudget.UI.Forms
{
    partial class FamilyForm
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
            labelTitle = new Label();
            dataGridViewFamily = new DataGridView();
            buttonCreateFamily = new Button();
            buttonShowMembers = new Button();
            buttonLoadFamilies = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFamily).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(100, 88, 255);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Семья";
            // 
            // dataGridViewFamily
            // 
            dataGridViewFamily.AllowUserToAddRows = false;
            dataGridViewFamily.AllowUserToDeleteRows = false;
            dataGridViewFamily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFamily.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFamily.Location = new Point(20, 80);
            dataGridViewFamily.Name = "dataGridViewFamily";
            dataGridViewFamily.ReadOnly = true;
            dataGridViewFamily.RowHeadersVisible = false;
            dataGridViewFamily.RowHeadersWidth = 51;
            dataGridViewFamily.Size = new Size(700, 400);
            dataGridViewFamily.TabIndex = 1;
            // 
            // buttonCreateFamily
            // 
            buttonCreateFamily.BackColor = Color.FromArgb(100, 88, 255);
            buttonCreateFamily.FlatStyle = FlatStyle.Flat;
            buttonCreateFamily.Font = new Font("Segoe UI", 10F);
            buttonCreateFamily.ForeColor = Color.White;
            buttonCreateFamily.Location = new Point(20, 500);
            buttonCreateFamily.Name = "buttonCreateFamily";
            buttonCreateFamily.Size = new Size(195, 40);
            buttonCreateFamily.TabIndex = 2;
            buttonCreateFamily.Text = "Создать семью";
            buttonCreateFamily.UseVisualStyleBackColor = false;
            // 
            // buttonJoinFamily
            // 
            buttonShowMembers.BackColor = Color.FromArgb(100, 88, 255);
            buttonShowMembers.FlatStyle = FlatStyle.Flat;
            buttonShowMembers.Font = new Font("Segoe UI", 10F);
            buttonShowMembers.ForeColor = Color.White;
            buttonShowMembers.Location = new Point(221, 500);
            buttonShowMembers.Name = "buttonShowMembers";
            buttonShowMembers.Size = new Size(236, 40);
            buttonShowMembers.TabIndex = 3;
            buttonShowMembers.Text = "Показать членов семьи";
            buttonShowMembers.UseVisualStyleBackColor = false;
            buttonShowMembers.Click += ButtonShowMembers_Click;
            // 
            // buttonLoadFamilies
            // 
            buttonLoadFamilies.BackColor = Color.FromArgb(100, 88, 255);
            buttonLoadFamilies.FlatStyle = FlatStyle.Flat;
            buttonLoadFamilies.Font = new Font("Segoe UI", 10F);
            buttonLoadFamilies.ForeColor = Color.White;
            buttonLoadFamilies.Location = new Point(463, 500);
            buttonLoadFamilies.Name = "buttonLoadFamilies";
            buttonLoadFamilies.Size = new Size(257, 40);
            buttonLoadFamilies.TabIndex = 4;
            buttonLoadFamilies.Text = "Показать мои семьи";
            buttonLoadFamilies.UseVisualStyleBackColor = false;
            buttonLoadFamilies.Click += ButtonLoadFamilies_Click;
            // 
            // FamilyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 570);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewFamily);
            Controls.Add(buttonCreateFamily);
            Controls.Add(buttonShowMembers);
            Controls.Add(buttonLoadFamilies);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FamilyForm";
            Text = "Семья";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFamily).EndInit();
            ResumeLayout(false);
        }
        private Label labelTitle;
        private DataGridView dataGridViewFamily;
        private Button buttonCreateFamily;
        private Button buttonShowMembers;
        private Button buttonLoadFamilies;
        #endregion
    }
}