namespace FamilyBudget.UI.Forms
{
    partial class CreateFamilyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelFamilyName = new Label();
            textBoxFamilyName = new TextBox();
            buttonCreate = new Button();
            buttonCancel = new Button();

            SuspendLayout();

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(20, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(206, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Создание семьи";

            // labelFamilyName
            labelFamilyName.AutoSize = true;
            labelFamilyName.Location = new Point(20, 50);
            labelFamilyName.Name = "labelFamilyName";
            labelFamilyName.Size = new Size(127, 20);
            labelFamilyName.TabIndex = 1;
            labelFamilyName.Text = "Название семьи:";

            // textBoxFamilyName
            textBoxFamilyName.Location = new Point(20, 70);
            textBoxFamilyName.Name = "textBoxFamilyName";
            textBoxFamilyName.Size = new Size(300, 27);
            textBoxFamilyName.TabIndex = 2;

            // buttonCreate
            buttonCreate.Location = new Point(20, 120);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;

            // buttonCancel
            buttonCancel.Location = new Point(120, 120);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;

            // CreateFamilyForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 170);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxFamilyName);
            Controls.Add(labelFamilyName);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateFamilyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Создание семьи";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFamilyName;
        private System.Windows.Forms.TextBox textBoxFamilyName;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
    }
}
