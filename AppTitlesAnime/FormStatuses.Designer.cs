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
            panelTop = new Panel();
            panelFill = new Panel();
            buttonDeleteStatuse = new Button();
            buttonUpdateStatuse = new Button();
            buttonAddStatuse = new Button();
            dataGridViewStatuses = new DataGridView();
            panelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(buttonDeleteStatuse);
            panelTop.Controls.Add(buttonUpdateStatuse);
            panelTop.Controls.Add(buttonAddStatuse);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(476, 100);
            panelTop.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewStatuses);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 100);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(476, 350);
            panelFill.TabIndex = 1;
            // 
            // buttonDeleteStatuse
            // 
            buttonDeleteStatuse.AutoSize = true;
            buttonDeleteStatuse.Font = new Font("Segoe UI", 14F);
            buttonDeleteStatuse.Location = new Point(281, 24);
            buttonDeleteStatuse.Name = "buttonDeleteStatuse";
            buttonDeleteStatuse.Size = new Size(92, 35);
            buttonDeleteStatuse.TabIndex = 5;
            buttonDeleteStatuse.Text = "Удалить";
            buttonDeleteStatuse.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateStatuse
            // 
            buttonUpdateStatuse.AutoSize = true;
            buttonUpdateStatuse.Font = new Font("Segoe UI", 14F);
            buttonUpdateStatuse.Location = new Point(124, 24);
            buttonUpdateStatuse.Name = "buttonUpdateStatuse";
            buttonUpdateStatuse.Size = new Size(151, 35);
            buttonUpdateStatuse.TabIndex = 4;
            buttonUpdateStatuse.Text = "Редактировать";
            buttonUpdateStatuse.UseVisualStyleBackColor = true;
            // 
            // buttonAddStatuse
            // 
            buttonAddStatuse.AutoSize = true;
            buttonAddStatuse.Font = new Font("Segoe UI", 14F);
            buttonAddStatuse.Location = new Point(12, 24);
            buttonAddStatuse.Name = "buttonAddStatuse";
            buttonAddStatuse.Size = new Size(106, 35);
            buttonAddStatuse.TabIndex = 3;
            buttonAddStatuse.Text = "Добавить";
            buttonAddStatuse.UseVisualStyleBackColor = true;
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
            dataGridViewStatuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatuses.Size = new Size(456, 330);
            dataGridViewStatuses.TabIndex = 1;
            // 
            // FormStatuses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Name = "FormStatuses";
            Text = "FormStatuses";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatuses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelFill;
        private Button buttonDeleteStatuse;
        private Button buttonUpdateStatuse;
        private Button buttonAddStatuse;
        private DataGridView dataGridViewStatuses;
    }
}