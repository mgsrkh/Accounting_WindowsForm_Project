﻿using Accounting_Project.Forms;
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
    public partial class UserManagement : MetroFramework.Forms.MetroForm
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void NewUser_bt_Click(object sender, EventArgs e)
        {
            NewUserForm uf = new NewUserForm();
            uf.Show();
        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {

        }
    }
}