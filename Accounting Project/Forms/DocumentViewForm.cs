using Accounting_Project.IRepositories;
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
    public partial class DocumentViewForm : MetroFramework.Forms.MetroForm
    {
        private readonly IDocumentRepository _repository;
        public DocumentViewForm()
        {
            InitializeComponent();
            _repository = new DocumentRepository();
        }

        private void DocumentViewForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            metroGrid1.Columns[2].HeaderText = "ردیف";
            metroGrid1.Columns[3].HeaderText = "نام سند";
            metroGrid1.Columns[4].HeaderText = "شماره سند";
            metroGrid1.Columns[5].HeaderText = "تاریخ سند";
            metroGrid1.Columns[6].HeaderText = "شماره صفحه";
            metroGrid1.Columns[7].HeaderText = "کد معین";
            metroGrid1.Columns[8].HeaderText = "کد کل";
            metroGrid1.Columns[9].HeaderText = "بده کار";
            metroGrid1.Columns[10].HeaderText = "بستانکار";
            metroGrid1.Columns[11].HeaderText = "جمع بده کار";
            metroGrid1.Columns[12].HeaderText = "مانده حساب";
        }
        public void LoadGrid()
        {
            metroGrid1.DataSource = _repository.GetAllByProcedure();
        }
        private void DocumentViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Id = (int)metroGrid1.Rows[e.RowIndex].Cells["Id"].Value;
                UpdateDocument updateDocument = new UpdateDocument(Id);
                updateDocument.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                int Id = (int)metroGrid1.Rows[e.RowIndex].Cells["Id"].Value;
                var result = MetroFramework.MetroMessageBox.Show(this, "آیا مطمئن هستید این آیتم حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    _repository.Delete(Id);
                    DocumentViewForm documentViewForm = (DocumentViewForm)Application.OpenForms["DocumentViewForm"];
                    documentViewForm.LoadGrid();
                }
                else
                {
                    DocumentViewForm documentViewForm = (DocumentViewForm)Application.OpenForms["DocumentViewForm"];
                    documentViewForm.LoadGrid();
                }
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
