namespace Accounting_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserManagement_mti = new MetroFramework.Controls.MetroTile();
            this.NewAccount_mti = new MetroFramework.Controls.MetroTile();
            this.NewDocument_mti = new MetroFramework.Controls.MetroTile();
            this.Taraz4Sotouni_mti = new MetroFramework.Controls.MetroTile();
            this.MandeHesabReport_mti = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // UserManagement_mti
            // 
            this.UserManagement_mti.ActiveControl = null;
            this.UserManagement_mti.Location = new System.Drawing.Point(131, 179);
            this.UserManagement_mti.Name = "UserManagement_mti";
            this.UserManagement_mti.Size = new System.Drawing.Size(165, 56);
            this.UserManagement_mti.Style = MetroFramework.MetroColorStyle.Green;
            this.UserManagement_mti.TabIndex = 0;
            this.UserManagement_mti.Text = "مدیریت کاربران";
            this.UserManagement_mti.UseSelectable = true;
            this.UserManagement_mti.Click += new System.EventHandler(this.UserManagement_mti_Click);
            // 
            // NewAccount_mti
            // 
            this.NewAccount_mti.ActiveControl = null;
            this.NewAccount_mti.Location = new System.Drawing.Point(302, 179);
            this.NewAccount_mti.Name = "NewAccount_mti";
            this.NewAccount_mti.Size = new System.Drawing.Size(165, 56);
            this.NewAccount_mti.Style = MetroFramework.MetroColorStyle.Green;
            this.NewAccount_mti.TabIndex = 1;
            this.NewAccount_mti.Text = "تعریف حساب";
            this.NewAccount_mti.UseSelectable = true;
            this.NewAccount_mti.Click += new System.EventHandler(this.NewAccount_mti_Click);
            // 
            // NewDocument_mti
            // 
            this.NewDocument_mti.ActiveControl = null;
            this.NewDocument_mti.Location = new System.Drawing.Point(473, 179);
            this.NewDocument_mti.Name = "NewDocument_mti";
            this.NewDocument_mti.Size = new System.Drawing.Size(165, 56);
            this.NewDocument_mti.Style = MetroFramework.MetroColorStyle.Green;
            this.NewDocument_mti.TabIndex = 2;
            this.NewDocument_mti.Text = "صدور سند";
            this.NewDocument_mti.UseSelectable = true;
            this.NewDocument_mti.Click += new System.EventHandler(this.NewDocument_mti_Click);
            // 
            // Taraz4Sotouni_mti
            // 
            this.Taraz4Sotouni_mti.ActiveControl = null;
            this.Taraz4Sotouni_mti.Location = new System.Drawing.Point(131, 241);
            this.Taraz4Sotouni_mti.Name = "Taraz4Sotouni_mti";
            this.Taraz4Sotouni_mti.Size = new System.Drawing.Size(260, 56);
            this.Taraz4Sotouni_mti.Style = MetroFramework.MetroColorStyle.Green;
            this.Taraz4Sotouni_mti.TabIndex = 3;
            this.Taraz4Sotouni_mti.Text = "تراز چهار ستونی و مانده حساب";
            this.Taraz4Sotouni_mti.UseSelectable = true;
            this.Taraz4Sotouni_mti.Click += new System.EventHandler(this.Taraz4Sotouni_mti_Click);
            // 
            // MandeHesabReport_mti
            // 
            this.MandeHesabReport_mti.ActiveControl = null;
            this.MandeHesabReport_mti.Location = new System.Drawing.Point(397, 241);
            this.MandeHesabReport_mti.Name = "MandeHesabReport_mti";
            this.MandeHesabReport_mti.Size = new System.Drawing.Size(241, 56);
            this.MandeHesabReport_mti.Style = MetroFramework.MetroColorStyle.Green;
            this.MandeHesabReport_mti.TabIndex = 4;
            this.MandeHesabReport_mti.Text = "گزارش مانده حساب";
            this.MandeHesabReport_mti.UseSelectable = true;
            this.MandeHesabReport_mti.Click += new System.EventHandler(this.MandeHesabReport_mti_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MandeHesabReport_mti);
            this.Controls.Add(this.Taraz4Sotouni_mti);
            this.Controls.Add(this.NewDocument_mti);
            this.Controls.Add(this.NewAccount_mti);
            this.Controls.Add(this.UserManagement_mti);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "فرم اصلی";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile UserManagement_mti;
        private MetroFramework.Controls.MetroTile NewAccount_mti;
        private MetroFramework.Controls.MetroTile NewDocument_mti;
        private MetroFramework.Controls.MetroTile Taraz4Sotouni_mti;
        private MetroFramework.Controls.MetroTile MandeHesabReport_mti;
    }
}