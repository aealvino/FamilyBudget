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
            this.labelTitle = new Label();
            this.dataGridViewFamily = new DataGridView();
            this.buttonCreateFamily = new Button();
            this.buttonJoinFamily = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamily)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.labelTitle.ForeColor = Color.FromArgb(100, 88, 255);
            this.labelTitle.Location = new Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(300, 40);
            this.labelTitle.Text = "Семья";

            // dataGridViewFamily
            this.dataGridViewFamily.AllowUserToAddRows = false;
            this.dataGridViewFamily.AllowUserToDeleteRows = false;
            this.dataGridViewFamily.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFamily.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamily.Location = new Point(20, 80);
            this.dataGridViewFamily.Name = "dataGridViewFamily";
            this.dataGridViewFamily.ReadOnly = true;
            this.dataGridViewFamily.RowHeadersVisible = false;
            this.dataGridViewFamily.Size = new Size(700, 400);

            // buttonCreateFamily
            this.buttonCreateFamily.BackColor = Color.FromArgb(100, 88, 255);
            this.buttonCreateFamily.FlatStyle = FlatStyle.Flat;
            this.buttonCreateFamily.Font = new Font("Segoe UI", 10F);
            this.buttonCreateFamily.ForeColor = Color.White;
            this.buttonCreateFamily.Location = new Point(20, 500);
            this.buttonCreateFamily.Name = "buttonCreateFamily";
            this.buttonCreateFamily.Size = new Size(150, 40);
            this.buttonCreateFamily.Text = "Создать семью";
            this.buttonCreateFamily.UseVisualStyleBackColor = false;

            // buttonJoinFamily
            this.buttonJoinFamily.BackColor = Color.FromArgb(100, 88, 255);
            this.buttonJoinFamily.FlatStyle = FlatStyle.Flat;
            this.buttonJoinFamily.Font = new Font("Segoe UI", 10F);
            this.buttonJoinFamily.ForeColor = Color.White;
            this.buttonJoinFamily.Location = new Point(200, 500);
            this.buttonJoinFamily.Name = "buttonJoinFamily";
            this.buttonJoinFamily.Size = new Size(180, 40);
            this.buttonJoinFamily.Text = "Присоединиться к семье";
            this.buttonJoinFamily.UseVisualStyleBackColor = false;

            // FamilyForm
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(750, 570);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewFamily);
            this.Controls.Add(this.buttonCreateFamily);
            this.Controls.Add(this.buttonJoinFamily);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FamilyForm";
            this.Text = "Семья";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamily)).EndInit();
            this.ResumeLayout(false);
        }
        private Label labelTitle;
        private DataGridView dataGridViewFamily;
        private Button buttonCreateFamily;
        private Button buttonJoinFamily;

        #endregion
    }
}