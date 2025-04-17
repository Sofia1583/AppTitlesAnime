namespace AppTitlesAnime
{
    partial class FormAddGenre
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
            labelGenreName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            errorProviderGenre = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxGenreName);
            panelFill.Controls.Add(labelGenreName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(434, 85);
            panelFill.TabIndex = 0;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.BorderStyle = BorderStyle.FixedSingle;
            textBoxGenreName.Dock = DockStyle.Top;
            textBoxGenreName.Font = new Font("Segoe UI", 14F);
            textBoxGenreName.Location = new Point(10, 35);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(404, 32);
            textBoxGenreName.TabIndex = 1;
            textBoxGenreName.TextChanged += TextBoxGenreName_TextChanged;
            textBoxGenreName.Validating += TextBoxGenreName_Validating;
            // 
            // labelGenreName
            // 
            labelGenreName.AutoSize = true;
            labelGenreName.Dock = DockStyle.Top;
            labelGenreName.Font = new Font("Segoe UI", 14F);
            labelGenreName.Location = new Point(10, 10);
            labelGenreName.Margin = new Padding(3);
            labelGenreName.Name = "labelGenreName";
            labelGenreName.Size = new Size(120, 25);
            labelGenreName.TabIndex = 1;
            labelGenreName.Text = "Жанр аниме";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.White;
            flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
            flowLayoutPanelBottom.Controls.Add(btnCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 85);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(434, 61);
            flowLayoutPanelBottom.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.AutoSize = true;
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Font = new Font("Segoe UI", 14F);
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
            btnCancel.Font = new Font("Segoe UI", 14F);
            btnCancel.Location = new Point(139, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProviderGenre
            // 
            errorProviderGenre.ContainerControl = this;
            // 
            // FormAddGenre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 146);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Name = "FormAddGenre";
            Text = "FormAddGenre";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        protected internal TextBox textBoxGenreName;
        private Label labelGenreName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnSaveChanges;
        private Button btnCancel;
        private ErrorProvider errorProviderGenre;
    }
}