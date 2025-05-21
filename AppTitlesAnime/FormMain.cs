using AppTitlesAnime.Models;

namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void ButtonGenre_Click(object sender, EventArgs e)
        {
            FormListGenres genreForm = new FormListGenres();
            genreForm.Show();
        }

        private void ButtonShowStatuses_Click(object sender, EventArgs e)
        {
            FormListStatuses statuseForm = new FormListStatuses();
            statuseForm.Show();
        }

        private void BtnShowTitles_Click(object sender, EventArgs e)
        {
            FormListTitles formListTitles = new FormListTitles();
            formListTitles.Show();
        }
    }
}
