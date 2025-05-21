using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;
namespace AppTitlesAnime
{
    public partial class formAddType : Form
    {
        private AppContext db;

        public formAddType()
        {
            InitializeComponent();
            db = new AppContext();
        }

        private void TextBoxType_TextChanged(object sender, EventArgs e)
        {
            ValidateType(); // Вызываем функцию валидации
        }

        private void TextBoxType_Validating(object sender, CancelEventArgs e)
        {
            ValidateType(); // Вызываем функцию валидации

            if (errorProviderType.GetError(textBoxType) != string.Empty)
            {
                e.Cancel = true; // Предотвращаем потерю фокуса, если есть ошибка
            }
        }

        private void ValidateType()
        {
            string typeName = textBoxType.Text.Trim();

            if (string.IsNullOrEmpty(typeName))
            {
                errorProviderType.SetError(textBoxType, "Поле не может быть пустым!");
                btnSaveChanges.Enabled = false;
                return; // Выходим, если поле пустое
            }

            try
            {
                bool typeExists = db.Types.Any(t => EF.Functions.Like((string)t.TypeName, typeName));

                if (typeExists)
                {
                    errorProviderType.SetError(textBoxType, "Такой объект уже существует");
                    btnSaveChanges.Enabled = false;
                }
                else
                {
                    errorProviderType.Clear();
                    btnSaveChanges.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
