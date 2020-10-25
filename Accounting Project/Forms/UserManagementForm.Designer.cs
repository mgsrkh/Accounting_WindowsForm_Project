namespace Accounting_Project
{
    partial class UserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.NewUser_bt = new MetroFramework.Controls.MetroButton();
            this.Edit_bt = new MetroFramework.Controls.MetroButton();
            this.Remove_bt = new MetroFramework.Controls.MetroButton();
            this.UserName_lb = new MetroFramework.Controls.MetroLabel();
            this.Password_lb = new MetroFramework.Controls.MetroLabel();
            this.UserName_txbox = new System.Windows.Forms.TextBox();
            this.Password_txbox = new System.Windows.Forms.TextBox();
            this.Save_bt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(754, 273);
            this.metroGrid1.TabIndex = 0;
            // 
            // NewUser_bt
            // 
            this.NewUser_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.NewUser_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.NewUser_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NewUser_bt.Location = new System.Drawing.Point(623, 358);
            this.NewUser_bt.Name = "NewUser_bt";
            this.NewUser_bt.Size = new System.Drawing.Size(154, 59);
            this.NewUser_bt.TabIndex = 1;
            this.NewUser_bt.Text = "کاربر جدید  +";
            this.NewUser_bt.UseSelectable = true;
            this.NewUser_bt.Click += new System.EventHandler(this.NewUser_bt_Click);
            // 
            // Edit_bt
            // 
            this.Edit_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Edit_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Edit_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Edit_bt.Location = new System.Drawing.Point(623, 423);
            this.Edit_bt.Name = "Edit_bt";
            this.Edit_bt.Size = new System.Drawing.Size(154, 59);
            this.Edit_bt.TabIndex = 2;
            this.Edit_bt.Text = "ویرایش";
            this.Edit_bt.UseSelectable = true;
            this.Edit_bt.Click += new System.EventHandler(this.Edit_bt_Click);
            // 
            // Remove_bt
            // 
            this.Remove_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Remove_bt.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Remove_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Remove_bt.Location = new System.Drawing.Point(623, 497);
            this.Remove_bt.Name = "Remove_bt";
            this.Remove_bt.Size = new System.Drawing.Size(154, 59);
            this.Remove_bt.TabIndex = 3;
            this.Remove_bt.Text = "حذف";
            this.Remove_bt.UseSelectable = true;
            // 
            // UserName_lb
            // 
            this.UserName_lb.AutoSize = true;
            this.UserName_lb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserName_lb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.UserName_lb.Location = new System.Drawing.Point(26, 367);
            this.UserName_lb.Name = "UserName_lb";
            this.UserName_lb.Size = new System.Drawing.Size(98, 25);
            this.UserName_lb.TabIndex = 4;
            this.UserName_lb.Text = "نام کاربری :";
            // 
            // Password_lb
            // 
            this.Password_lb.AutoSize = true;
            this.Password_lb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Password_lb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Password_lb.Location = new System.Drawing.Point(37, 441);
            this.Password_lb.Name = "Password_lb";
            this.Password_lb.Size = new System.Drawing.Size(87, 25);
            this.Password_lb.TabIndex = 5;
            this.Password_lb.Text = "رمز عبور :";
            // 
            // UserName_txbox
            // 
            this.UserName_txbox.Location = new System.Drawing.Point(131, 367);
            this.UserName_txbox.Multiline = true;
            this.UserName_txbox.Name = "UserName_txbox";
            this.UserName_txbox.Size = new System.Drawing.Size(364, 25);
            this.UserName_txbox.TabIndex = 6;
            // 
            // Password_txbox
            // 
            this.Password_txbox.Location = new System.Drawing.Point(130, 441);
            this.Password_txbox.Multiline = true;
            this.Password_txbox.Name = "Password_txbox";
            this.Password_txbox.PasswordChar = '*';
            this.Password_txbox.Size = new System.Drawing.Size(364, 25);
            this.Password_txbox.TabIndex = 7;
            // 
            // Save_bt
            // 
            this.Save_bt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Save_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Save_bt.Location = new System.Drawing.Point(37, 497);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(458, 59);
            this.Save_bt.TabIndex = 8;
            this.Save_bt.Text = "ذخیره";
            this.Save_bt.UseSelectable = true;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.Save_bt);
            this.Controls.Add(this.Password_txbox);
            this.Controls.Add(this.UserName_txbox);
            this.Controls.Add(this.Password_lb);
            this.Controls.Add(this.UserName_lb);
            this.Controls.Add(this.Remove_bt);
            this.Controls.Add(this.Edit_bt);
            this.Controls.Add(this.NewUser_bt);
            this.Controls.Add(this.metroGrid1);
            this.Name = "UserManagement";
            this.Text = "فرم مدیریت کاربران";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton NewUser_bt;
        private MetroFramework.Controls.MetroButton Edit_bt;
        private MetroFramework.Controls.MetroButton Remove_bt;
        private MetroFramework.Controls.MetroLabel UserName_lb;
        private MetroFramework.Controls.MetroLabel Password_lb;
        private System.Windows.Forms.TextBox UserName_txbox;
        private System.Windows.Forms.TextBox Password_txbox;
        private MetroFramework.Controls.MetroButton Save_bt;
    }
}