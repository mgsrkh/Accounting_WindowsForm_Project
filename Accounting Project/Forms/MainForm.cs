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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void NewAccount_mti_Click(object sender, EventArgs e)
        {
            NewAccount na = new NewAccount();
            na.Show();
        }

        private void UserManagement_mti_Click(object sender, EventArgs e)
        {
            //UserManagement um = UserManagement.CreateInstance();
            UserManagement um = new UserManagement();
            um.Show();
        }

        private void NewDocument_mti_Click(object sender, EventArgs e)
        {
            NewDocument nd = NewDocument.CreateInstance();
            if (nd != null)
            {
                nd.Show();
            }
            else
            {
                MessageBox.Show("متاسفانه به این آیتم دسترسی ندارین");
                //Mahdi Test
            }   
        }

        private void MandeHesabReport_mti_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
        }

        private void Taraz4Sotouni_mti_Click(object sender, EventArgs e)
        {
            Taraz4Sotouni taraz = Taraz4Sotouni.CreateInstance();
            taraz.Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
