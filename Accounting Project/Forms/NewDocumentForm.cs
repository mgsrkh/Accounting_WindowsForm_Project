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
    public partial class NewDocument : MetroFramework.Forms.MetroForm
    {
        private readonly IDocumentRepository _repository;
        private static NewDocument Singletone = null;
        private NewDocument()
        {
            InitializeComponent();
            _repository = new DocumentRepository();
        }

        public static NewDocument CreateInstance()
        {
            if (Singletone == null)
            {
                Singletone = new NewDocument();
            }
            return Singletone;
        }
        private void NewDocument_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Save_ti_Click(object sender, EventArgs e)
        {
            Document document = new Document()
            {
                DocumentName = AccountName_txbox.Text,
                DocumentNumber = Convert.ToInt32(DocumentNum_txbox.Text),
                DocumentDate = DateTime.Parse(DocumentDate_DateTime.Text),
                DocumentPage = Convert.ToInt32(DocumentPage_txbox.Text),
                MoaienCode = Convert.ToInt32(MoeenCode_txbox.Text),
                ColCode = Convert.ToInt32(ColCode_txbox.Text),
                Bedehkar = Convert.ToInt32(Bedehkar_txbox.Text),
                Bestankar = Convert.ToInt32(Bestankar_txbox.Text),
                TotalBedehkar = Convert.ToInt32(TotalBedehkar_txbox.Text),
                TotalBestankar = Convert.ToInt32(MandeHesab_txbox.Text)
            };

            int result = _repository.Insert(document);
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

        private void Document_gbox_Enter(object sender, EventArgs e)
        {

        }

        private void View_ti_Click(object sender, EventArgs e)
        {
            DocumentViewForm dvf = new DocumentViewForm();
            dvf.Show();
        }

        private void NewDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            DocumentViewForm dvf = new DocumentViewForm();
            dvf.Show();
        }
    }
}
