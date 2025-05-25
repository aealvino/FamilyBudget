namespace FamilyBudget.UI.Forms
{
    partial class AddFamilyMemberForm
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
        public string Email => textBoxEmail.Text;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEmail = new TextBox();
            this.buttonAdd = new Button();
            this.buttonCancel = new Button();
            this.labelEmail = new Label();

            this.SuspendLayout();

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 15);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(106, 20);
            this.labelEmail.Text = "Email пользователя:";

            // textBoxEmail
            this.textBoxEmail.Location = new System.Drawing.Point(15, 40);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(300, 27);

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(15, 80);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 35);
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;

            // buttonCancel
            this.buttonCancel.Location = new System.Drawing.Point(175, 80);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 35);
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;

            // AddFamilyMemberForm
            this.ClientSize = new System.Drawing.Size(340, 130);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Добавить члена семьи";

            this.ResumeLayout(false);
            this.PerformLayout();
    }
        private TextBox textBoxEmail;
        private Button buttonAdd;
        private Button buttonCancel;
        private Label labelEmail;
        #endregion
    }
}