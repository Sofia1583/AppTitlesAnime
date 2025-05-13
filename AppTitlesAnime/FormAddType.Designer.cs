namespace AppTitlesAnime
{
    partial class formAddType
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
            panelFill = new Panel();
            textBoxGenreName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            panelTop = new Panel();
            textBoxType = new TextBox();
            labelName = new Label();
            buttonSave = new Button();
            buttonCansel = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            errorProviderType = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderType).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxGenreName);
            panelFill.Controls.Add(labelTypeName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(434, 146);
            panelFill.TabIndex = 0;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.BorderStyle = BorderStyle.FixedSingle;
            textBoxGenreName.Dock = DockStyle.Top;
            textBoxGenreName.Location = new Point(10, 25);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(404, 23);
            textBoxGenreName.TabIndex = 1;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(10, 10);
            labelTypeName.Margin = new Padding(3);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(65, 15);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 85);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(434, 61);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(120, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить ";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(139, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(textBoxType);
            panelTop.Controls.Add(labelName);
            panelTop.Dock = DockStyle.Top;
            panelTop.Font = new Font("Segoe UI", 14F);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10, 10, 20, 10);
            panelTop.Size = new Size(434, 78);
            panelTop.TabIndex = 1;
            // 
            // textBoxType
            // 
            textBoxType.BorderStyle = BorderStyle.FixedSingle;
            textBoxType.Dock = DockStyle.Top;
            textBoxType.Font = new Font("Segoe UI", 14F);
            textBoxType.Location = new Point(10, 35);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(404, 32);
            textBoxType.TabIndex = 1;
            textBoxType.TextChanged += TextBoxType_TextChanged;
            textBoxType.Validating += TextBoxType_Validating;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.Font = new Font("Segoe UI", 14F);
            labelName.Location = new Point(10, 10);
            labelName.Margin = new Padding(3);
            labelName.Name = "labelName";
            labelName.Size = new Size(104, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Тип аниме";
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 14F);
            buttonSave.Location = new Point(13, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить ";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCansel
            // 
            buttonCansel.AutoSize = true;
            buttonCansel.DialogResult = DialogResult.Cancel;
            buttonCansel.Font = new Font("Segoe UI", 14F);
            buttonCansel.Location = new Point(139, 13);
            buttonCansel.Name = "buttonCansel";
            buttonCansel.Size = new Size(88, 35);
            buttonCansel.TabIndex = 1;
            buttonCansel.Text = "Отмена";
            buttonCansel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.BackColor = Color.White;
            flowLayoutPanel.Controls.Add(buttonSave);
            flowLayoutPanel.Controls.Add(buttonCansel);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 78);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(10);
            flowLayoutPanel.Size = new Size(434, 68);
            flowLayoutPanel.TabIndex = 2;
            // 
            // errorProviderType
            // 
            errorProviderType.ContainerControl = this;
            // 
            // formAddType
            // 
            ClientSize = new Size(434, 146);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panelTop);
            Name = "formAddType";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderType).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // 
            // errorProvider
            // 
        }

        #endregion

        private Panel panelFill;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelTypeName;
        protected internal TextBox textBoxGenreName;
        private Panel panelTop;
        protected internal TextBox textBoxType;
        private Label labelName;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonSave;
        private Button buttonCansel;
        private ErrorProvider errorProviderType;
    }
}