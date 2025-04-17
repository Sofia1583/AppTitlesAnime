using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormStatuses : Form
    {
        public FormStatuses()
        {
            InitializeComponent();
        }

        /*protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.StatuseName.Load(); // Загружаем Genres
            this.dataGridViewStatuses.DataSource = this.db.StatuseName.Local.OrderBy(o => o.GenreName).ToList();


            //скрытие столбцов
            dataGridViewStatuses.Columns["Id"].Visible = false;

            //изменение названий заголовков столбцов 
            dataGridViewStatuses.Columns["StatuseName"].HeaderText = "Статус аниме";
        }*/
    }
}
