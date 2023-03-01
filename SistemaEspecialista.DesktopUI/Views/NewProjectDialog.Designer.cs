namespace SistemaEspecialista.DesktopUI.Views
{
    partial class NewProjectDialog
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTxtRBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(49, 64);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(306, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // descriptionTxtRBox
            // 
            this.descriptionTxtRBox.Location = new System.Drawing.Point(49, 121);
            this.descriptionTxtRBox.Name = "descriptionTxtRBox";
            this.descriptionTxtRBox.Size = new System.Drawing.Size(306, 96);
            this.descriptionTxtRBox.TabIndex = 1;
            this.descriptionTxtRBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(49, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(146, 45);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(209, 238);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(146, 45);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Confirmar";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(49, 46);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(98, 15);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Nome do Projeto";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(49, 103);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(116, 15);
            this.descriptionLbl.TabIndex = 5;
            this.descriptionLbl.Text = "Descrição do projeto";
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 295);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.descriptionTxtRBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "NewProjectDialog";
            this.Text = "Novo projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private RichTextBox descriptionTxtRBox;
        private Button cancelButton;
        private Button okButton;
        private Label nameLbl;
        private Label descriptionLbl;
    }
}