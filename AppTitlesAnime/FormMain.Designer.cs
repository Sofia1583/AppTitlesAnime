namespace AppTitlesAnime
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowTypes = new Button();
            btnShowGenre = new Button();
            btnShowStatuses = new Button();
            btnShowTitles = new Button();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.BackColor = Color.White;
            btnShowTypes.Location = new Point(12, 12);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(313, 35);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "Отобразить список \"Типы аниме\"";
            btnShowTypes.UseVisualStyleBackColor = false;
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // btnShowGenre
            // 
            btnShowGenre.AutoSize = true;
            btnShowGenre.BackColor = Color.White;
            btnShowGenre.Location = new Point(12, 64);
            btnShowGenre.Name = "btnShowGenre";
            btnShowGenre.Size = new Size(329, 35);
            btnShowGenre.TabIndex = 1;
            btnShowGenre.Text = "Отобразить список \"Жанры аниме\"";
            btnShowGenre.UseVisualStyleBackColor = false;
            btnShowGenre.Click += ButtonGenre_Click;
            // 
            // btnShowStatuses
            // 
            btnShowStatuses.AutoSize = true;
            btnShowStatuses.BackColor = Color.White;
            btnShowStatuses.Location = new Point(12, 114);
            btnShowStatuses.Name = "btnShowStatuses";
            btnShowStatuses.Size = new Size(337, 35);
            btnShowStatuses.TabIndex = 2;
            btnShowStatuses.Text = "Отобразить список \"Статусы аниме\"";
            btnShowStatuses.UseVisualStyleBackColor = false;
            btnShowStatuses.Click += ButtonShowStatuses_Click;
            // 
            // btnShowTitles
            // 
            btnShowTitles.AutoSize = true;
            btnShowTitles.BackColor = Color.White;
            btnShowTitles.Location = new Point(12, 155);
            btnShowTitles.Name = "btnShowTitles";
            btnShowTitles.Size = new Size(337, 35);
            btnShowTitles.TabIndex = 3;
            btnShowTitles.Text = "Отобразить список \"Аниме\"";
            btnShowTitles.UseVisualStyleBackColor = false;
            btnShowTitles.Click += BtnShowTitles_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 347);
            Controls.Add(btnShowTitles);
            Controls.Add(btnShowStatuses);
            Controls.Add(btnShowGenre);
            Controls.Add(btnShowTypes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTypes;
        private Button btnShowGenre;
        private Button btnShowStatuses;
        private Button btnShowTitles;
    }
}
