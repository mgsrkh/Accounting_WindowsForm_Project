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

namespace Accounting_Project.Forms
{
    public partial class UpdateTaraz : MetroFramework.Forms.MetroForm
    {
        private readonly ITarazRepository _repository;
        private int _Id = 0;
        public UpdateTaraz(int id)
        {
            InitializeComponent();
            _repository = new TarazRepository();
            _Id = id;
        }

        private void UpdateTaraz_Load(object sender, EventArgs e)
        {
            Taraz taraz = _repository.GetById(_Id);
            AccountName_txbox.Text = taraz.AccountName;
            GardeshBedehkar_txbox.Text = taraz.GardeshBedehkar.ToString();
            GardeshBestankar_txbox.Text = taraz.GardeshBestankar.ToString();
            MandeBedehkar_txbox.Text = taraz.MandeBedehkar.ToString();
            MandeBestankar_txbox.Text = taraz.MandeBestankar.ToString();
            TotalGardeshBedehkar_txbox.Text = taraz.TotalGardeshBedehkar.ToString();
            TotalGardeshBestankar_txbox.Text = taraz.TotalGardeshBestankar.ToString();
            TotalMandeBedehkar_txbox.Text = taraz.TotalMandeBedehkar.ToString();
            TotalMandeBestankar_txbox.Text = taraz.TotalMandeBestankar.ToString();
        }

        private void Save_ti_Click(object sender, EventArgs e)
        {
            Taraz taraz = new Taraz()
            {
                Id = _Id,
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
            int result = _repository.Update(taraz);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا");
            }
        }

        private void UpdateTaraz_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewTarazForm viewTarazForm = (ViewTarazForm)Application.OpenForms["ViewTarazForm"];
            viewTarazForm.LoadGrid();
        }
    }
}
