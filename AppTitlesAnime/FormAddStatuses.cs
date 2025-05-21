using System.ComponentModel;
using AppContext = AppTitlesAnime.Models.AppContext;
namespace AppTitlesAnime
{
    public partial class FormAddStatuses : Form
    {
        private AppContext db;

        public FormAddStatuses()
        {
            InitializeComponent();
            db = new AppContext();
        }

        private void TextBoxForStatuses_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProviderStatus.SetError(textBoxStatusName, "Поле не может быть пустым!");
                buttonSaveChanges.Enabled = false;
            }
            else
            {
                errorProviderStatus.Clear();
                buttonSaveChanges.Enabled = true;
            }
        }

        private void TextBoxStatusName_Validating(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("Validating");
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProviderStatus.SetError(textBoxStatusName, "Поле не может быть пустым!");
                buttonSaveChanges.Enabled = false;
            }
            else
            {
                errorProviderStatus.Clear();
                buttonSaveChanges.Enabled = true;
            }

            string userStatus = textBoxStatusName.Text.Trim();

            try
            {
                bool statusExists = db.Statuses.Any(g => g.StatusName.ToLower() == userStatus.ToLower());

                if (statusExists)
                {
                    errorProviderStatus.SetError(textBoxStatusName, "Такой объект уже существует");
                    buttonSaveChanges.Enabled = false;
                }
                else
                {
                    errorProviderStatus.SetError(textBoxStatusName, string.Empty);
                    buttonSaveChanges.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }

}
