using System.ComponentModel;
using System.Data;
using AppTitlesAnime;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
using Status = AppTitlesAnime.Models.Status;

namespace AppTitlesAnime
{
    public partial class FormStatuses : Form
    {
        private AppContext db;

        public FormStatuses()
        {
            InitializeComponent();
            db = new AppContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Statuses.Load();
            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();


            //скрытие столбцов
            dataGridViewStatuses.Columns["Id"].Visible = false;
            dataGridViewStatuses.Columns["TitlesStatuses"].Visible = false;
            //изменение названий заголовков столбцов 
            dataGridViewStatuses.Columns["StatusName"].HeaderText = "Статус аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }
        private void ButtonAddStatus_Click(object sender, EventArgs e)
        {
            using (FormAddStatuses formAddStatuses = new())
            {
                DialogResult result = formAddStatuses.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                Status status = new Status();
                status.StatusName = formAddStatuses.textBoxStatusName.Text;

                try
                {
                    db.Statuses.Add(status);
                    db.SaveChanges();

                    MessageBox.Show("Новый объект добавлен");


                    this.dataGridViewStatuses.DataSource = this.db.Statuses.OrderBy(o => o.StatusName).ToList(); //Убрали .Local
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении статуса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Вспомогательный метод для получения ID статуса из DataGridView
        private short? GetSelectedStatusId()
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0)
                return null;

            var selectedRow = dataGridViewStatuses.SelectedRows[0];
            if (selectedRow.Cells[0].Value == null)
                return null;

            if (short.TryParse(selectedRow.Cells[0].Value.ToString(), out short id))
            {
                return id;
            }

            return null;
        }
        private short? GetStatusId()
        {
            if (dataGridViewStatuses.CurrentRow == null)
                return null;

            var val = dataGridViewStatuses.CurrentRow.Cells[0].Value;
            if (val == null)
                return null;

            if (short.TryParse(val.ToString(), out short id))
                return id;

            return null;
        }

        private void ButtonDeleteStatuse_Click(object sender, EventArgs e)
        {
            short? id = GetStatusId();

            if (!id.HasValue)
            {
                MessageBox.Show("Не удалось получить ID статуса для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                Status status = db.Statuses.Find(id.Value);
                if (status == null)
                {
                    MessageBox.Show("Объект не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.Statuses.Remove(status);
                db.SaveChanges();

                MessageBox.Show("Объект удален.");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUpdateStatuse_Click(object sender, EventArgs e)
        {
            short? id = GetStatusId();

            if (!id.HasValue)
            {
                MessageBox.Show("Не удалось получить ID статуса для обновления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Status status = db.Statuses.Find(id.Value);
                if (status == null)
                {
                    MessageBox.Show("Объект не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormAddStatuses formAddStatuses = new();
                formAddStatuses.textBoxStatusName.Text = status.StatusName;

                DialogResult result = formAddStatuses.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                status.StatusName = formAddStatuses.textBoxStatusName.Text;
                db.SaveChanges();

                MessageBox.Show("Объект изменен.");
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            this.dataGridViewStatuses.DataSource = db.Statuses.OrderBy(o => o.StatusName).ToList();
        }
    }

    }
