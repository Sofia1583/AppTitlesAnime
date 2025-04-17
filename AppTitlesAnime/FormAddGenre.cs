using System.ComponentModel;

namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form
    {
        public FormAddGenre()
        {
            InitializeComponent();
        }

        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProviderGenre.SetError(textBoxGenreName, "Поле не может быть пустым!");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProviderGenre.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxGenreName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProviderGenre.SetError(textBoxGenreName, "Поле не может быть пустым!");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProviderGenre.Clear();
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
