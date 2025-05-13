namespace AppTitlesAnime
{
    partial class FormStatuses
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
            buttonDeleteStatuse = new Button();
            buttonUpdateStatuse = new Button();
            buttonAddStatus = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelFill = new Panel();
            dataGridViewStatuses = new DataGridView();
            errorProviderStatuses = new ErrorProvider(components);
            flowLayoutPanel1.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderStatuses).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteStatuse
            // 
            buttonDeleteStatuse.AutoSize = true;
            buttonDeleteStatuse.Font = new Font("Segoe UI", 14F);
            buttonDeleteStatuse.Location = new Point(272, 3);
            buttonDeleteStatuse.Name = "buttonDeleteStatuse";
            buttonDeleteStatuse.Size = new Size(92, 35);
            buttonDeleteStatuse.TabIndex = 2;
            buttonDeleteStatuse.Text = "Удалить";
            buttonDeleteStatuse.UseVisualStyleBackColor = true;
            buttonDeleteStatuse.Click += ButtonDeleteStatuse_Click;
            // 
            // buttonUpdateStatuse
            // 
            buttonUpdateStatuse.AutoSize = true;
            buttonUpdateStatuse.Font = new Font("Segoe UI", 14F);
            buttonUpdateStatuse.Location = new Point(115, 3);
            buttonUpdateStatuse.Name = "buttonUpdateStatuse";
            buttonUpdateStatuse.Size = new Size(151, 35);
            buttonUpdateStatuse.TabIndex = 1;
            buttonUpdateStatuse.Text = "Редактировать";
            buttonUpdateStatuse.UseVisualStyleBackColor = true;
            buttonUpdateStatuse.Click += ButtonUpdateStatuse_Click;
            // 
            // buttonAddStatus
            // 
            buttonAddStatus.AutoSize = true;
            buttonAddStatus.Font = new Font("Segoe UI", 14F);
            buttonAddStatus.Location = new Point(3, 3);
            buttonAddStatus.Name = "buttonAddStatus";
            buttonAddStatus.Size = new Size(106, 35);
            buttonAddStatus.TabIndex = 0;
            buttonAddStatus.Text = "Добавить";
            buttonAddStatus.UseVisualStyleBackColor = true;
            buttonAddStatus.Click += ButtonAddStatus_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(buttonAddStatus);
            flowLayoutPanel1.Controls.Add(buttonUpdateStatuse);
            flowLayoutPanel1.Controls.Add(buttonDeleteStatuse);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(476, 75);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewStatuses);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Font = new Font("Segoe UI", 14F);
            panelFill.Location = new Point(0, 75);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(476, 375);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewStatuses
            // 
            dataGridViewStatuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatuses.BackgroundColor = Color.White;
            dataGridViewStatuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatuses.Dock = DockStyle.Fill;
            dataGridViewStatuses.Location = new Point(10, 10);
            dataGridViewStatuses.MultiSelect = false;
            dataGridViewStatuses.Name = "dataGridViewStatuses";
            dataGridViewStatuses.ReadOnly = true;
            dataGridViewStatuses.Size = new Size(456, 355);
            dataGridViewStatuses.TabIndex = 0;
            // 
            // errorProviderStatuses
            // 
            errorProviderStatuses.ContainerControl = this;
            // 
            // FormStatuses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel1);
            Name = "FormStatuses";
            Text = "FormStatuses";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderStatuses).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDeleteStatuse;
        private Button buttonUpdateStatuse;
        private Button buttonAddStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridViewStatuses;
        protected Panel panelFill;
        private ErrorProvider errorProviderStatuses;
    }
}