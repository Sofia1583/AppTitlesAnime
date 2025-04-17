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
            panelTop = new Panel();
            buttonDeleteGenre = new Button();
            buttonUpdateGenre = new Button();
            buttonAddGenre = new Button();
            panel1 = new Panel();
            dataGridViewGenres = new DataGridView();
            panelTop.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(buttonDeleteGenre);
            panelTop.Controls.Add(buttonUpdateGenre);
            panelTop.Controls.Add(buttonAddGenre);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(934, 71);
            panelTop.TabIndex = 0;
            // 
            // buttonDeleteGenre
            // 
            buttonDeleteGenre.AutoSize = true;
            buttonDeleteGenre.Font = new Font("Segoe UI", 14F);
            buttonDeleteGenre.Location = new Point(278, 13);
            buttonDeleteGenre.Name = "buttonDeleteGenre";
            buttonDeleteGenre.Size = new Size(92, 35);
            buttonDeleteGenre.TabIndex = 2;
            buttonDeleteGenre.Text = "Удалить";
            buttonDeleteGenre.UseVisualStyleBackColor = true;
            buttonDeleteGenre.Click += ButtonDeleteGenre_Click;
            // 
            // buttonUpdateGenre
            // 
            buttonUpdateGenre.AutoSize = true;
            buttonUpdateGenre.Font = new Font("Segoe UI", 14F);
            buttonUpdateGenre.Location = new Point(121, 13);
            buttonUpdateGenre.Name = "buttonUpdateGenre";
            buttonUpdateGenre.Size = new Size(151, 35);
            buttonUpdateGenre.TabIndex = 1;
            buttonUpdateGenre.Text = "Редактировать";
            buttonUpdateGenre.UseVisualStyleBackColor = true;
            buttonUpdateGenre.Click += ButtonUpdateGenre_Click;
            // 
            // buttonAddGenre
            // 
            buttonAddGenre.AutoSize = true;
            buttonAddGenre.Font = new Font("Segoe UI", 14F);
            buttonAddGenre.Location = new Point(9, 13);
            buttonAddGenre.Name = "buttonAddGenre";
            buttonAddGenre.Size = new Size(106, 35);
            buttonAddGenre.TabIndex = 0;
            buttonAddGenre.Text = "Добавить";
            buttonAddGenre.UseVisualStyleBackColor = true;
            buttonAddGenre.Click += ButtonAddGenre_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridViewGenres);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 14F);
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(934, 440);
            panel1.TabIndex = 1;
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Dock = DockStyle.Fill;
            dataGridViewGenres.Location = new Point(10, 10);
            dataGridViewGenres.MultiSelect = false;
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.ReadOnly = true;
            dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenres.Size = new Size(914, 420);
            dataGridViewGenres.TabIndex = 0;
            // 
            // FormGenreTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Name = "FormGenreTypes";
            Text = "Список жанров аниме";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel1;
        private DataGridView dataGridViewGenres;
        private Button buttonDeleteGenre;
        private Button buttonUpdateGenre;
        private Button buttonAddGenre;
    }
}