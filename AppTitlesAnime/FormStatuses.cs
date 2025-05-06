using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormStatuses : Form
    {
        private AppContext db;
        public FormStatuses()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.StatusName.Load(); // Загружаем Statuses
            this.dataGridViewStatuses.DataSource = this.db.StatusName.Local.OrderBy(o => o.StatusName).ToList();


            //скрытие столбцов
            dataGridViewStatuses.Columns["Id"].Visible = false;

            //изменение названий заголовков столбцов 
            dataGridViewStatuses.Columns["StatuseName"].HeaderText = "Статус аниме";
        }
    }
}
