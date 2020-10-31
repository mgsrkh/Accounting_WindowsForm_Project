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
    public partial class ViewTarazForm : MetroFramework.Forms.MetroForm
    {
        private readonly ITarazRepository _repository;
        public ViewTarazForm()
        {
            InitializeComponent();
            _repository = new TarazRepository();
        }
        public void LoadGrid()
        {
            metroGrid1.DataSource = _repository.GetAllByProcedure();
        }
        private void ViewTarazForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            metroGrid1.Columns[2].HeaderText = "ردیف";
            metroGrid1.Columns[3].HeaderText = "نام حساب";
            metroGrid1.Columns[4].HeaderText = "گردش بده کار";
            metroGrid1.Columns[5].HeaderText = "گردش بستانکار";
            metroGrid1.Columns[6].HeaderText = "مانده بده کار";
            metroGrid1.Columns[7].HeaderText = "مانده بستانکار";
            metroGrid1.Columns[8].HeaderText = "جمع گردش بده کار";
            metroGrid1.Columns[9].HeaderText = "جمع گردش بستانکار";
            metroGrid1.Columns[10].HeaderText = "جمع مانده بده کار";
            metroGrid1.Columns[11].HeaderText = "جمع مانده  بستانکار";
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Id = (int)metroGrid1.Rows[e.RowIndex].Cells["Id"].Value;
                UpdateTaraz updateTaraz = new UpdateTaraz(Id);
                updateTaraz.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                int Id = (int)metroGrid1.Rows[e.RowIndex].Cells["Id"].Value;
                var result = MetroFramework.MetroMessageBox.Show(this, "آیا مطمئن هستید این آیتم حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    _repository.Delete(Id);

                    ViewTarazForm viewTarazForm = (ViewTarazForm)Application.OpenForms["ViewTarazForm"];
                    viewTarazForm.LoadGrid();
                }
                else
                {
                    ViewTarazForm viewTarazForm = (ViewTarazForm)Application.OpenForms["ViewTarazForm"];
                    viewTarazForm.LoadGrid();
                }
            }
        }
    }
}
