namespace AppTitlesAnime.Models
{
    partial class FormGenreTypes
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
            dataGridViewGenres = new DataGridView();
            buttonAddGenre = new Button();
            buttonUpdateGenre = new Button();
            buttonDeleteGenre = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            errorProviderGenre = new ErrorProvider(components);
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewGenres);
            panelFill.Dock = DockStyle.Bottom;
            panelFill.Font = new Font("Segoe UI", 14F);
            panelFill.Location = new Point(0, 98);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 413);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Dock = DockStyle.Bottom;
            dataGridViewGenres.Location = new Point(10, 8);
            dataGridViewGenres.MultiSelect = false;
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.ReadOnly = true;
            dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenres.Size = new Size(914, 395);
            dataGridViewGenres.TabIndex = 0;
            // 
            // buttonAddGenre
            // 
            buttonAddGenre.AutoSize = true;
            buttonAddGenre.Font = new Font("Segoe UI", 14F);
            buttonAddGenre.Location = new Point(3, 3);
            buttonAddGenre.Name = "buttonAddGenre";
            buttonAddGenre.Size = new Size(106, 35);
            buttonAddGenre.TabIndex = 0;
            buttonAddGenre.Text = "Добавить";
            buttonAddGenre.UseVisualStyleBackColor = true;
            buttonAddGenre.Click += ButtonAddGenre_Click;
            // 
            // buttonUpdateGenre
            // 
            buttonUpdateGenre.AutoSize = true;
            buttonUpdateGenre.Font = new Font("Segoe UI", 14F);
            buttonUpdateGenre.Location = new Point(115, 3);
            buttonUpdateGenre.Name = "buttonUpdateGenre";
            buttonUpdateGenre.Size = new Size(151, 35);
            buttonUpdateGenre.TabIndex = 1;
            buttonUpdateGenre.Text = "Редактировать";
            buttonUpdateGenre.UseVisualStyleBackColor = true;
            buttonUpdateGenre.Click += ButtonUpdateGenre_Click;
            // 
            // buttonDeleteGenre
            // 
            buttonDeleteGenre.AutoSize = true;
            buttonDeleteGenre.Font = new Font("Segoe UI", 14F);
            buttonDeleteGenre.Location = new Point(272, 3);
            buttonDeleteGenre.Name = "buttonDeleteGenre";
            buttonDeleteGenre.Size = new Size(92, 35);
            buttonDeleteGenre.TabIndex = 2;
            buttonDeleteGenre.Text = "Удалить";
            buttonDeleteGenre.UseVisualStyleBackColor = true;
            buttonDeleteGenre.Click += ButtonDeleteGenre_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.BackColor = Color.White;
            flowLayoutPanel.Controls.Add(buttonAddGenre);
            flowLayoutPanel.Controls.Add(buttonUpdateGenre);
            flowLayoutPanel.Controls.Add(buttonDeleteGenre);
            flowLayoutPanel.Dock = DockStyle.Top;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(934, 100);
            flowLayoutPanel.TabIndex = 3;
            // 
            // errorProviderGenre
            // 
            errorProviderGenre.ContainerControl = this;
            // 
            // FormGenreTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panelFill);
            Name = "FormGenreTypes";
            Text = "Список жанров аниме";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGenre).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFill;
        private DataGridView dataGridViewGenres;
        private Button buttonAddGenre;
        private Button buttonUpdateGenre;
        private Button buttonDeleteGenre;
        private FlowLayoutPanel flowLayoutPanel;
        private ErrorProvider errorProviderGenre;
    }
}