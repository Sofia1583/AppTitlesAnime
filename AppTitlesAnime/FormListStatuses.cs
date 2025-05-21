using System.ComponentModel;
using System.Data;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
namespace AppTitlesAnime
{
    public partial class FormListStatuses : Form
    {
        private AppContext db;
        public FormListStatuses()
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

            dataGridViewStatuses.Columns["Id"].Visible = false;
            dataGridViewStatuses.Columns["TitlesStatuses"].Visible = false;
            dataGridViewStatuses.Columns["StatusName"].HeaderText = "Статус аниме";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db.Dispose();
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


                    this.dataGridViewStatuses.DataSource = this.db.Statuses.OrderBy(o => o.StatusName).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении статуса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonUpdateStatuse_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0)
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Status status = db.Statuses.Find(id);
            FormAddStatuses formAddStatus = new();
            formAddStatus.textBoxStatusName.Text = status.StatusName;

            DialogResult result = formAddStatus.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            status.StatusName = formAddStatus.textBoxStatusName.Text;
            db.Statuses.Update(status);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }

        private void ButtonDeleteStatuse_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверенны, что хотите удалить объект? " +
                "\nВсе связанные данные будут удалены",
                "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
                return;

            int index = dataGridViewStatuses.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewStatuses[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            Status status = db.Statuses.Find(id);

            db.Statuses.Remove(status);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();
        }
        
    }
}
