using System.ComponentModel;
using AppContext = AppTitlesAnime.Models.AppContext;
namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form
    {
        private AppContext db;

        public FormAddGenre(AppContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        public FormAddGenre()
        {
            InitializeComponent();
            this.db = new AppContext();
        }

        private bool IsGenreNameValid()
        {
            if (string.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProviderGenre.SetError(textBoxGenreName, "Поле не может быть пустым!");
                btnSaveChanges.Enabled = false;
                return false;
            }
            else
            {
                errorProviderGenre.Clear();
                btnSaveChanges.Enabled = true;
                return true;
            }
        }

        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsGenreNameValid())
            {
                return; // Validation failed, stop further processing
            }

            string userGenre = textBoxGenreName.Text.Trim();

            try
            {
                bool genreExists = db.GenreName.Any(g => g.GenreName.ToLower() == userGenre.ToLower());

                if (genreExists)
                {
                    errorProviderGenre.SetError(textBoxGenreName, "Такой объект уже существует");
                    btnSaveChanges.Enabled = false;
                }
                else
                {
                    errorProviderGenre.SetError(textBoxGenreName, string.Empty);
                    btnSaveChanges.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void TextBoxGenreName_TextChanged(object sender, EventArgs e)
        {
            IsGenreNameValid();
        }
    }
}
