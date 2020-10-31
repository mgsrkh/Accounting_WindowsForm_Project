namespace Accounting_Project.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.UserName_tx = new MetroFramework.Controls.MetroTextBox();
            this.Password_tx = new MetroFramework.Controls.MetroTextBox();
            this.Login_ti = new MetroFramework.Controls.MetroTile();
            this.Exit_ti = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(54, 414);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "نام کاربری :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(65, 492);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "رمز عبور :";
            // 
            // UserName_tx
            // 
            // 
            // 
            // 
            this.UserName_tx.CustomButton.Image = null;
            this.UserName_tx.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.UserName_tx.CustomButton.Name = "";
            this.UserName_tx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.UserName_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserName_tx.CustomButton.TabIndex = 1;
            this.UserName_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName_tx.CustomButton.UseSelectable = true;
            this.UserName_tx.CustomButton.Visible = false;
            this.UserName_tx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.UserName_tx.Lines = new string[0];
            this.UserName_tx.Location = new System.Drawing.Point(207, 414);
            this.UserName_tx.MaxLength = 32767;
            this.UserName_tx.Name = "UserName_tx";
            this.UserName_tx.PasswordChar = '\0';
            this.UserName_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserName_tx.SelectedText = "";
            this.UserName_tx.SelectionLength = 0;
            this.UserName_tx.SelectionStart = 0;
            this.UserName_tx.ShortcutsEnabled = true;
            this.UserName_tx.Size = new System.Drawing.Size(258, 27);
            this.UserName_tx.TabIndex = 4;
            this.UserName_tx.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserName_tx.UseSelectable = true;
            this.UserName_tx.WaterMark = "نام کاربری را وارد نمایید";
            this.UserName_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserName_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Password_tx
            // 
            // 
            // 
            // 
            this.Password_tx.CustomButton.Image = null;
            this.Password_tx.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.Password_tx.CustomButton.Name = "";
            this.Password_tx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Password_tx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password_tx.CustomButton.TabIndex = 1;
            this.Password_tx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password_tx.CustomButton.UseSelectable = true;
            this.Password_tx.CustomButton.Visible = false;
            this.Password_tx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Password_tx.Lines = new string[0];
            this.Password_tx.Location = new System.Drawing.Point(207, 494);
            this.Password_tx.MaxLength = 32767;
            this.Password_tx.Name = "Password_tx";
            this.Password_tx.PasswordChar = '●';
            this.Password_tx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password_tx.SelectedText = "";
            this.Password_tx.SelectionLength = 0;
            this.Password_tx.SelectionStart = 0;
            this.Password_tx.ShortcutsEnabled = true;
            this.Password_tx.Size = new System.Drawing.Size(258, 27);
            this.Password_tx.TabIndex = 5;
            this.Password_tx.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password_tx.UseSelectable = true;
            this.Password_tx.UseSystemPasswordChar = true;
            this.Password_tx.WaterMark = "رمز عبور را وارد نمایید";
            this.Password_tx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Password_tx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login_ti
            // 
            this.Login_ti.ActiveControl = null;
            this.Login_ti.AutoSize = true;
            this.Login_ti.BackColor = System.Drawing.Color.Black;
            this.Login_ti.Location = new System.Drawing.Point(63, 560);
            this.Login_ti.Name = "Login_ti";
            this.Login_ti.Size = new System.Drawing.Size(198, 53);
            this.Login_ti.Style = MetroFramework.MetroColorStyle.Red;
            this.Login_ti.TabIndex = 6;
            this.Login_ti.Text = "ورود";
            this.Login_ti.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Login_ti.UseSelectable = true;
            this.Login_ti.Click += new System.EventHandler(this.Login_ti_Click);
            // 
            // Exit_ti
            // 
            this.Exit_ti.ActiveControl = null;
            this.Exit_ti.Location = new System.Drawing.Point(267, 560);
            this.Exit_ti.Name = "Exit_ti";
            this.Exit_ti.Size = new System.Drawing.Size(198, 53);
            this.Exit_ti.Style = MetroFramework.MetroColorStyle.Red;
            this.Exit_ti.TabIndex = 7;
            this.Exit_ti.Text = "خروج";
            this.Exit_ti.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Exit_ti.UseSelectable = true;
            this.Exit_ti.Click += new System.EventHandler(this.Exit_ti_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(39, 155);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(449, 211);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(345, 53);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(143, 82);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile2.TabIndex = 9;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(530, 664);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.Exit_ti);
            this.Controls.Add(this.Login_ti);
            this.Controls.Add(this.Password_tx);
            this.Controls.Add(this.UserName_tx);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "ورود کاربر";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox UserName_tx;
        private MetroFramework.Controls.MetroTextBox Password_tx;
        private MetroFramework.Controls.MetroTile Login_ti;
        private MetroFramework.Controls.MetroTile Exit_ti;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}