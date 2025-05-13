namespace AppTitlesAnime
{
    partial class FormAddStatuses
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
            components = new System.ComponentModel.Container();
            panelTop = new Panel();
            textBoxStatusName = new TextBox();
            labelStatuses = new Label();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSaveChanges = new Button();
            errorProviderStatus = new ErrorProvider(components);
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderStatus).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(textBoxStatusName);
            panelTop.Controls.Add(labelStatuses);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Font = new Font("Segoe UI", 14F);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(434, 146);
            panelTop.TabIndex = 0;
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Location = new Point(12, 42);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(404, 32);
            textBoxStatusName.TabIndex = 1;
            textBoxStatusName.TextChanged += TextBoxForStatuses_TextChanged;
            textBoxStatusName.Validating += TextBoxStatusName_Validating;
            // 
            // labelStatuses
            // 
            labelStatuses.AutoSize = true;
            labelStatuses.Location = new Point(17, 14);
            labelStatuses.Name = "labelStatuses";
            labelStatuses.Size = new Size(141, 25);
            labelStatuses.TabIndex = 0;
            labelStatuses.Text = "Статусы аниме";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSaveChanges);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 89);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(434, 57);
            panelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 14F);
            buttonCancel.Location = new Point(133, 10);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.AutoSize = true;
            buttonSaveChanges.DialogResult = DialogResult.OK;
            buttonSaveChanges.Font = new Font("Segoe UI", 14F);
            buttonSaveChanges.Location = new Point(12, 10);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(115, 35);
            buttonSaveChanges.TabIndex = 0;
            buttonSaveChanges.Text = "Сохранить";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // errorProviderStatus
            // 
            errorProviderStatus.ContainerControl = this;
            // 
            // FormAddStatuses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 146);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "FormAddStatuses";
            Text = "AddStatuses";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSaveChanges;
        private Label labelStatuses;
        private ErrorProvider errorProviderStatus;
        public TextBox textBoxStatusName;
    }
}