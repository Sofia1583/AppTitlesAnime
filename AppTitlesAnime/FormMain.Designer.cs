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
            buttonGenre = new Button();
            buttonShowStatuses = new Button();
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
            // buttonGenre
            // 
            buttonGenre.AutoSize = true;
            buttonGenre.BackColor = Color.White;
            buttonGenre.Location = new Point(12, 64);
            buttonGenre.Name = "buttonGenre";
            buttonGenre.Size = new Size(329, 35);
            buttonGenre.TabIndex = 1;
            buttonGenre.Text = "Отобразить список \"Жанры аниме\"";
            buttonGenre.UseVisualStyleBackColor = false;
            buttonGenre.Click += ButtonGenre_Click;
            // 
            // buttonShowStatuses
            // 
            buttonShowStatuses.AutoSize = true;
            buttonShowStatuses.BackColor = Color.White;
            buttonShowStatuses.Location = new Point(12, 114);
            buttonShowStatuses.Name = "buttonShowStatuses";
            buttonShowStatuses.Size = new Size(337, 35);
            buttonShowStatuses.TabIndex = 2;
            buttonShowStatuses.Text = "Отобразить список \"Статусы аниме\"";
            buttonShowStatuses.UseVisualStyleBackColor = false;
            buttonShowStatuses.Click += ButtonShowStatuses_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 347);
            Controls.Add(buttonShowStatuses);
            Controls.Add(buttonGenre);
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
        private Button buttonGenre;
        private Button buttonShowStatuses;
    }
}
