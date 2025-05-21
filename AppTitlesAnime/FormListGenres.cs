using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace AppTitlesAnime.Models
{
    public partial class FormListGenres : Form
    {
        private AppContext db;

        public FormListGenres()
        {
            InitializeComponent();
            db = new AppContext();
            this.db = db;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.GenreName.Load(); // Загружаем Genres
            this.dataGridViewGenres.DataSource = this.db.GenreName.Local.OrderBy(o => o.GenreName).ToList();


            //скрытие столбцов
            dataGridViewGenres.Columns["Id"].Visible = false;
            dataGridViewGenres.Columns["TitlesGenres"].Visible = false;

            //изменение названий заголовков столбцов 
            dataGridViewGenres.Columns["GenreName"].HeaderText = "Жанр аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }
        private void ButtonUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.GenreName.Find(id);
            FormAddGenre formAddGenre = new();
            formAddGenre.textBoxGenreName.Text = genre.GenreName;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            genre.GenreName = formAddGenre.textBoxGenreName.Text;
            db.GenreName.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewGenres.DataSource = this.db.GenreName.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void ButtonDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenres.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;


            int index = dataGridViewGenres.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.GenreName.Find(id);
            db.GenreName.Remove(genre);
            db.SaveChanges();
            MessageBox.Show("Объект удален");

            this.dataGridViewGenres.DataSource = this.db.GenreName.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void ButtonAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxGenreName.Text;

            db.GenreName.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
            this.dataGridViewGenres.DataSource = this.db.GenreName.Local.OrderBy(o => o.GenreName).ToList();
        }
    }
}
    
        
    
    