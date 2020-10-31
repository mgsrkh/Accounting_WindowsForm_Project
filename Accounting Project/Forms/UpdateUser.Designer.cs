namespace Accounting_Project.Forms
{
    partial class UpdateUser
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
            this.Type_txbox = new System.Windows.Forms.TextBox();
            this.Password_txbox = new System.Windows.Forms.TextBox();
            this.UserName_txbox = new System.Windows.Forms.TextBox();
            this.Type_lb = new System.Windows.Forms.Label();
            this.Password_lb = new System.Windows.Forms.Label();
            this.UserName_lb = new System.Windows.Forms.Label();
            this.Save_ti = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Type_txbox
            // 
            this.Type_txbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_txbox.Location = new System.Drawing.Point(23, 251);
            this.Type_txbox.Multiline = true;
            this.Type_txbox.Name = "Type_txbox";
            this.Type_txbox.Size = new System.Drawing.Size(309, 32);
            this.Type_txbox.TabIndex = 14;
            // 
            // Password_txbox
            // 
            this.Password_txbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txbox.Location = new System.Drawing.Point(23, 174);
            this.Password_txbox.Multiline = true;
            this.Password_txbox.Name = "Password_txbox";
            this.Password_txbox.PasswordChar = '●';
            this.Password_txbox.Size = new System.Drawing.Size(309, 31);
            this.Password_txbox.TabIndex = 13;
            // 
            // UserName_txbox
            // 
            this.UserName_txbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_txbox.Location = new System.Drawing.Point(23, 95);
            this.UserName_txbox.Multiline = true;
            this.UserName_txbox.Name = "UserName_txbox";
            this.UserName_txbox.Size = new System.Drawing.Size(309, 31);
            this.UserName_txbox.TabIndex = 12;
            // 
            // Type_lb
            // 
            this.Type_lb.AutoSize = true;
            this.Type_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_lb.Location = new System.Drawing.Point(338, 256);
            this.Type_lb.Name = "Type_lb";
            this.Type_lb.Size = new System.Drawing.Size(92, 20);
            this.Type_lb.TabIndex = 10;
            this.Type_lb.Text = ": نوع کاربر ";
            // 
            // Password_lb
            // 
            this.Password_lb.AutoSize = true;
            this.Password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lb.Location = new System.Drawing.Point(338, 179);
            this.Password_lb.Name = "Password_lb";
            this.Password_lb.Size = new System.Drawing.Size(85, 20);
            this.Password_lb.TabIndex = 9;
            this.Password_lb.Text = ": رمز عبور";
            // 
            // UserName_lb
            // 
            this.UserName_lb.AutoSize = true;
            this.UserName_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_lb.Location = new System.Drawing.Point(338, 100);
            this.UserName_lb.Name = "UserName_lb";
            this.UserName_lb.Size = new System.Drawing.Size(98, 20);
            this.UserName_lb.TabIndex = 8;
            this.UserName_lb.Text = ": نام کاربری ";
            // 
            // Save_ti
            // 
            this.Save_ti.ActiveControl = null;
            this.Save_ti.Location = new System.Drawing.Point(15, 341);
            this.Save_ti.Name = "Save_ti";
            this.Save_ti.Size = new System.Drawing.Size(134, 50);
            this.Save_ti.TabIndex = 11;
            this.Save_ti.Text = "ویرایش";
            this.Save_ti.UseSelectable = true;
            this.Save_ti.Click += new System.EventHandler(this.Save_ti_Click_1);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 419);
            this.Controls.Add(this.Type_txbox);
            this.Controls.Add(this.Password_txbox);
            this.Controls.Add(this.UserName_txbox);
            this.Controls.Add(this.Save_ti);
            this.Controls.Add(this.Type_lb);
            this.Controls.Add(this.Password_lb);
            this.Controls.Add(this.UserName_lb);
            this.Name = "UpdateUser";
            this.Text = "ویرایش";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateUser_FormClosed);
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Type_txbox;
        private System.Windows.Forms.TextBox Password_txbox;
        private System.Windows.Forms.TextBox UserName_txbox;
        private System.Windows.Forms.Label Type_lb;
        private System.Windows.Forms.Label Password_lb;
        private System.Windows.Forms.Label UserName_lb;
        private MetroFramework.Controls.MetroTile Save_ti;
    }
}