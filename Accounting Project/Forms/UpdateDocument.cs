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
    public partial class UpdateDocument : MetroFramework.Forms.MetroForm
    {
        private readonly IDocumentRepository _repository;
        private int _Id = 0;
        public UpdateDocument(int id)
        {
            InitializeComponent();
            _repository = new DocumentRepository();
            _Id = id;
        }

        private void UpdateDocument_Load(object sender, EventArgs e)
        {
            Document document = _repository.GetById(_Id);
            AccountName_txbox.Text = document.DocumentName;
            DocumentNum_txbox.Text = document.DocumentNumber.ToString();
            DocumentDate_DateTime.Text = document.DocumentDate.ToString();
            DocumentPage_txbox.Text = document.DocumentPage.ToString();
            MoeenCode_txbox.Text = document.MoaienCode.ToString();
            ColCode_txbox.Text = document.ColCode.ToString();
            Bedehkar_txbox.Text = document.Bedehkar.ToString();
            Bestankar_txbox.Text = document.Bestankar.ToString();
            TotalBedehkar_txbox.Text = document.TotalBedehkar.ToString();
            MandeHesab_txbox.Text = document.TotalBestankar.ToString();
        }

        private void Save_ti_Click(object sender, EventArgs e)
        {
            Document document = new Document()
            {
                Id = _Id,
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
            int result = _repository.Update(document);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا");
            }
        }

        private void View_ti_Click(object sender, EventArgs e)
        {
            DocumentViewForm dvf = new DocumentViewForm();
            dvf.Show();
        }

        private void UpdateDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            DocumentViewForm documentViewForm = (DocumentViewForm)Application.OpenForms["DocumentViewForm"];
            documentViewForm.LoadGrid();
        }
    }
}
