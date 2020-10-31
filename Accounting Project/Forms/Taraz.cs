using Accounting_Project.Forms;
using Accounting_Project.IRepositories;
using Accounting_Project.Models;
using Accounting_Project.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Project
{
    public partial class Taraz4Sotouni : MetroFramework.Forms.MetroForm
    {
        private readonly ITarazRepository _repository;
        private static Taraz4Sotouni Singletone = null;
        private Taraz4Sotouni()
        {
            InitializeComponent();
            _repository = new TarazRepository();
        }

        private void Taraz4Sotouni_Load(object sender, EventArgs e)
        {

        }
        public static Taraz4Sotouni CreateInstance()
        {
            if (Singletone == null)
            {
                Singletone = new Taraz4Sotouni();
            }
            return Singletone;
        }

        private void Save_ti_Click(object sender, EventArgs e)
        {
            Taraz taraz = new Taraz()
            {
                AccountName = AccountName_txbox.Text,
                GardeshBedehkar = Convert.ToInt32(GardeshBedehkar_txbox.Text),
                GardeshBestankar = Convert.ToInt32(GardeshBestankar_txbox.Text),
                MandeBedehkar = Convert.ToInt32(MandeBedehkar_txbox.Text),
                MandeBestankar = Convert.ToInt32(MandeBestankar_txbox.Text),
                TotalGardeshBedehkar = Convert.ToInt32(TotalGardeshBedehkar_txbox.Text),
                TotalGardeshBestankar = Convert.ToInt32(TotalGardeshBestankar_txbox.Text),
                TotalMandeBedehkar = Convert.ToInt32(TotalMandeBedehkar_txbox.Text),
                TotalMandeBestankar = Convert.ToInt32(TotalMandeBestankar_txbox.Text)
            };

            int result = _repository.Insert(taraz);
            if (result > 0)
            {
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا");
            }
        }

        private void View_ti_Click(object sender, EventArgs e)
        {
            ViewTarazForm vtf = new ViewTarazForm();
            vtf.Show();
        }

        private void Taraz4Sotouni_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewTarazForm vtf = new ViewTarazForm();
            vtf.Show();
        }
    }
}
