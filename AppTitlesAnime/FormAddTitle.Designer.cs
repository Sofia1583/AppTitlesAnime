namespace AppTitlesAnime
{
    partial class FormAddTitle
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
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxStudio = new TextBox();
            labelStudio = new Label();
            numUpDownDuration = new NumericUpDown();
            labelDuration = new Label();
            numUpDownCountSeries = new NumericUpDown();
            labelCountSeries = new Label();
            comboBoxType = new ComboBox();
            labelTypeAnime = new Label();
            textBoxAnimeName = new TextBox();
            labelNameAnime = new Label();
            textBoxOriginalName = new TextBox();
            labelOriginalName = new Label();
            flowLayoutPanelFill = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCansel = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCountSeries).BeginInit();
            flowLayoutPanelFill.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(textBoxDescription);
            panelTop.Controls.Add(labelDescription);
            panelTop.Controls.Add(textBoxStudio);
            panelTop.Controls.Add(labelStudio);
            panelTop.Controls.Add(numUpDownDuration);
            panelTop.Controls.Add(labelDuration);
            panelTop.Controls.Add(numUpDownCountSeries);
            panelTop.Controls.Add(labelCountSeries);
            panelTop.Controls.Add(comboBoxType);
            panelTop.Controls.Add(labelTypeAnime);
            panelTop.Controls.Add(textBoxAnimeName);
            panelTop.Controls.Add(labelNameAnime);
            panelTop.Controls.Add(textBoxOriginalName);
            panelTop.Controls.Add(labelOriginalName);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Font = new Font("Segoe UI", 14F);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10, 10, 20, 10);
            panelTop.Size = new Size(434, 539);
            panelTop.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(10, 402);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(404, 32);
            textBoxDescription.TabIndex = 13;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(13, 374);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(99, 25);
            labelDescription.TabIndex = 12;
            labelDescription.Text = "Описание";
            // 
            // textBoxStudio
            // 
            textBoxStudio.Location = new Point(10, 339);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(404, 32);
            textBoxStudio.TabIndex = 11;
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.Location = new Point(13, 311);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(72, 25);
            labelStudio.TabIndex = 10;
            labelStudio.Text = "Студия";
            // 
            // numUpDownDuration
            // 
            numUpDownDuration.Location = new Point(9, 276);
            numUpDownDuration.Name = "numUpDownDuration";
            numUpDownDuration.Size = new Size(405, 32);
            numUpDownDuration.TabIndex = 9;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(10, 248);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(292, 25);
            labelDuration.TabIndex = 8;
            labelDuration.Text = "Продолжительность серии, мин";
            // 
            // numUpDownCountSeries
            // 
            numUpDownCountSeries.Location = new Point(10, 213);
            numUpDownCountSeries.Name = "numUpDownCountSeries";
            numUpDownCountSeries.Size = new Size(404, 32);
            numUpDownCountSeries.TabIndex = 7;
            // 
            // labelCountSeries
            // 
            labelCountSeries.AutoSize = true;
            labelCountSeries.Location = new Point(10, 185);
            labelCountSeries.Name = "labelCountSeries";
            labelCountSeries.Size = new Size(171, 25);
            labelCountSeries.TabIndex = 6;
            labelCountSeries.Text = "Количество серий";
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Fill;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(10, 149);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(404, 33);
            comboBoxType.TabIndex = 5;
            // 
            // labelTypeAnime
            // 
            labelTypeAnime.AutoSize = true;
            labelTypeAnime.Dock = DockStyle.Top;
            labelTypeAnime.Font = new Font("Segoe UI", 14F);
            labelTypeAnime.Location = new Point(10, 124);
            labelTypeAnime.Margin = new Padding(3);
            labelTypeAnime.Name = "labelTypeAnime";
            labelTypeAnime.Size = new Size(104, 25);
            labelTypeAnime.TabIndex = 4;
            labelTypeAnime.Text = "Тип аниме";
            // 
            // textBoxAnimeName
            // 
            textBoxAnimeName.BorderStyle = BorderStyle.FixedSingle;
            textBoxAnimeName.Dock = DockStyle.Top;
            textBoxAnimeName.Font = new Font("Segoe UI", 14F);
            textBoxAnimeName.Location = new Point(10, 92);
            textBoxAnimeName.Name = "textBoxAnimeName";
            textBoxAnimeName.Size = new Size(404, 32);
            textBoxAnimeName.TabIndex = 3;
            // 
            // labelNameAnime
            // 
            labelNameAnime.AutoSize = true;
            labelNameAnime.Dock = DockStyle.Top;
            labelNameAnime.Font = new Font("Segoe UI", 14F);
            labelNameAnime.Location = new Point(10, 67);
            labelNameAnime.Margin = new Padding(3);
            labelNameAnime.Name = "labelNameAnime";
            labelNameAnime.Size = new Size(155, 25);
            labelNameAnime.TabIndex = 2;
            labelNameAnime.Text = "Название аниме";
            // 
            // textBoxOriginalName
            // 
            textBoxOriginalName.BorderStyle = BorderStyle.FixedSingle;
            textBoxOriginalName.Dock = DockStyle.Top;
            textBoxOriginalName.Font = new Font("Segoe UI", 14F);
            textBoxOriginalName.Location = new Point(10, 35);
            textBoxOriginalName.Name = "textBoxOriginalName";
            textBoxOriginalName.Size = new Size(404, 32);
            textBoxOriginalName.TabIndex = 1;
            // 
            // labelOriginalName
            // 
            labelOriginalName.AutoSize = true;
            labelOriginalName.Dock = DockStyle.Top;
            labelOriginalName.Font = new Font("Segoe UI", 14F);
            labelOriginalName.Location = new Point(10, 10);
            labelOriginalName.Margin = new Padding(3);
            labelOriginalName.Name = "labelOriginalName";
            labelOriginalName.Size = new Size(178, 25);
            labelOriginalName.TabIndex = 1;
            labelOriginalName.Text = "Оригинальное имя";
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.BackColor = Color.White;
            flowLayoutPanelFill.Controls.Add(buttonSave);
            flowLayoutPanelFill.Controls.Add(buttonCansel);
            flowLayoutPanelFill.Dock = DockStyle.Bottom;
            flowLayoutPanelFill.Font = new Font("Segoe UI", 14F);
            flowLayoutPanelFill.Location = new Point(0, 471);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(434, 68);
            flowLayoutPanelFill.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 14F);
            buttonSave.Location = new Point(13, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(121, 35);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить ";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCansel
            // 
            buttonCansel.AutoSize = true;
            buttonCansel.DialogResult = DialogResult.Cancel;
            buttonCansel.Font = new Font("Segoe UI", 14F);
            buttonCansel.Location = new Point(140, 13);
            buttonCansel.Name = "buttonCansel";
            buttonCansel.Size = new Size(89, 35);
            buttonCansel.TabIndex = 2;
            buttonCansel.Text = "Отмена";
            buttonCansel.UseVisualStyleBackColor = true;
            // 
            // FormAddTitle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 539);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(panelTop);
            Name = "FormAddTitle";
            Text = "Информация об аниме";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCountSeries).EndInit();
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        protected internal TextBox textBoxOriginalName;
        private Label labelOriginalName;
        private FlowLayoutPanel flowLayoutPanelFill;
        private Button buttonSave;
        private Button buttonCansel;
        private Label labelTypeAnime;
        protected internal TextBox textBoxAnimeName;
        private Label labelNameAnime;
        private Label labelCountSeries;
        private Label labelDuration;
        private Label labelStudio;
        private Label labelDescription;
        public NumericUpDown numUpDownCountSeries;
        public NumericUpDown numUpDownDuration;
        public TextBox textBoxDescription;
        public TextBox textBoxStudio;
        public ComboBox comboBoxType;
    }
}