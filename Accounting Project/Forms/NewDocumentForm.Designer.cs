namespace Accounting_Project
{
    partial class NewDocument
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
            this.Document_gbox = new System.Windows.Forms.GroupBox();
            this.DocumentDate_DateTime = new MetroFramework.Controls.MetroDateTime();
            this.DocumentPage_txbox = new System.Windows.Forms.TextBox();
            this.DocumentPage_lb = new MetroFramework.Controls.MetroLabel();
            this.DocumentDate_lb = new MetroFramework.Controls.MetroLabel();
            this.Document_lbl = new System.Windows.Forms.Label();
            this.DocumentDetail_lb = new MetroFramework.Controls.MetroLabel();
            this.DocumentNum_txbox = new System.Windows.Forms.TextBox();
            this.DocumentNum_lb = new MetroFramework.Controls.MetroLabel();
            this.Save_ti = new MetroFramework.Controls.MetroTile();
            this.View_ti = new MetroFramework.Controls.MetroTile();
            this.MoeenCode_lb = new System.Windows.Forms.Label();
            this.ColCode_lb = new System.Windows.Forms.Label();
            this.AccountName_lb = new System.Windows.Forms.Label();
            this.Bestankar_lb = new System.Windows.Forms.Label();
            this.Bedehkar_lb = new System.Windows.Forms.Label();
            this.MandeHesab_lb = new System.Windows.Forms.Label();
            this.AccountName_txbox = new System.Windows.Forms.TextBox();
            this.MoeenCode_txbox = new System.Windows.Forms.TextBox();
            this.ColCode_txbox = new System.Windows.Forms.TextBox();
            this.Bedehkar_txbox = new System.Windows.Forms.TextBox();
            this.Bestankar_txbox = new System.Windows.Forms.TextBox();
            this.MandeHesab_txbox = new System.Windows.Forms.TextBox();
            this.DocumentTotal_lb = new System.Windows.Forms.Label();
            this.TotalBedehkar_txbox = new System.Windows.Forms.TextBox();
            this.TotalBestankar_txbox = new System.Windows.Forms.TextBox();
            this.Document_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Document_gbox
            // 
            this.Document_gbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Document_gbox.Controls.Add(this.DocumentDate_DateTime);
            this.Document_gbox.Controls.Add(this.DocumentPage_txbox);
            this.Document_gbox.Controls.Add(this.DocumentPage_lb);
            this.Document_gbox.Controls.Add(this.DocumentDate_lb);
            this.Document_gbox.Controls.Add(this.Document_lbl);
            this.Document_gbox.Controls.Add(this.DocumentDetail_lb);
            this.Document_gbox.Controls.Add(this.DocumentNum_txbox);
            this.Document_gbox.Controls.Add(this.DocumentNum_lb);
            this.Document_gbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document_gbox.Location = new System.Drawing.Point(24, 86);
            this.Document_gbox.Name = "Document_gbox";
            this.Document_gbox.Size = new System.Drawing.Size(845, 151);
            this.Document_gbox.TabIndex = 0;
            this.Document_gbox.TabStop = false;
            this.Document_gbox.Enter += new System.EventHandler(this.Document_gbox_Enter);
            // 
            // DocumentDate_DateTime
            // 
            this.DocumentDate_DateTime.Location = new System.Drawing.Point(6, 21);
            this.DocumentDate_DateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.DocumentDate_DateTime.Name = "DocumentDate_DateTime";
            this.DocumentDate_DateTime.Size = new System.Drawing.Size(170, 30);
            this.DocumentDate_DateTime.TabIndex = 8;
            // 
            // DocumentPage_txbox
            // 
            this.DocumentPage_txbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentPage_txbox.Location = new System.Drawing.Point(52, 101);
            this.DocumentPage_txbox.Multiline = true;
            this.DocumentPage_txbox.Name = "DocumentPage_txbox";
            this.DocumentPage_txbox.Size = new System.Drawing.Size(75, 27);
            this.DocumentPage_txbox.TabIndex = 7;
            // 
            // DocumentPage_lb
            // 
            this.DocumentPage_lb.AutoSize = true;
            this.DocumentPage_lb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DocumentPage_lb.Location = new System.Drawing.Point(133, 101);
            this.DocumentPage_lb.Name = "DocumentPage_lb";
            this.DocumentPage_lb.Size = new System.Drawing.Size(57, 20);
            this.DocumentPage_lb.TabIndex = 6;
            this.DocumentPage_lb.Text = ": صفحه";
            this.DocumentPage_lb.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // DocumentDate_lb
            // 
            this.DocumentDate_lb.AutoSize = true;
            this.DocumentDate_lb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DocumentDate_lb.Location = new System.Drawing.Point(182, 26);
            this.DocumentDate_lb.Name = "DocumentDate_lb";
            this.DocumentDate_lb.Size = new System.Drawing.Size(77, 20);
            this.DocumentDate_lb.TabIndex = 4;
            this.DocumentDate_lb.Text = ": تاریخ سند";
            // 
            // Document_lbl
            // 
            this.Document_lbl.AutoSize = true;
            this.Document_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document_lbl.Location = new System.Drawing.Point(264, 61);
            this.Document_lbl.Name = "Document_lbl";
            this.Document_lbl.Size = new System.Drawing.Size(311, 32);
            this.Document_lbl.TabIndex = 3;
            this.Document_lbl.Text = "-----   سند حسابداری   -----";
            // 
            // DocumentDetail_lb
            // 
            this.DocumentDetail_lb.AutoSize = true;
            this.DocumentDetail_lb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DocumentDetail_lb.Location = new System.Drawing.Point(732, 94);
            this.DocumentDetail_lb.Name = "DocumentDetail_lb";
            this.DocumentDetail_lb.Size = new System.Drawing.Size(74, 20);
            this.DocumentDetail_lb.TabIndex = 2;
            this.DocumentDetail_lb.Text = ": شرح سند";
            // 
            // DocumentNum_txbox
            // 
            this.DocumentNum_txbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentNum_txbox.Location = new System.Drawing.Point(614, 26);
            this.DocumentNum_txbox.Multiline = true;
            this.DocumentNum_txbox.Name = "DocumentNum_txbox";
            this.DocumentNum_txbox.Size = new System.Drawing.Size(100, 32);
            this.DocumentNum_txbox.TabIndex = 1;
            // 
            // DocumentNum_lb
            // 
            this.DocumentNum_lb.AutoSize = true;
            this.DocumentNum_lb.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DocumentNum_lb.Location = new System.Drawing.Point(720, 26);
            this.DocumentNum_lb.Name = "DocumentNum_lb";
            this.DocumentNum_lb.Size = new System.Drawing.Size(86, 20);
            this.DocumentNum_lb.TabIndex = 0;
            this.DocumentNum_lb.Text = ": شماره سند";
            // 
            // Save_ti
            // 
            this.Save_ti.ActiveControl = null;
            this.Save_ti.Location = new System.Drawing.Point(24, 499);
            this.Save_ti.Name = "Save_ti";
            this.Save_ti.Size = new System.Drawing.Size(135, 52);
            this.Save_ti.Style = MetroFramework.MetroColorStyle.Green;
            this.Save_ti.TabIndex = 1;
            this.Save_ti.Text = "ذخیره";
            this.Save_ti.UseSelectable = true;
            this.Save_ti.Click += new System.EventHandler(this.Save_ti_Click);
            // 
            // View_ti
            // 
            this.View_ti.ActiveControl = null;
            this.View_ti.Location = new System.Drawing.Point(165, 499);
            this.View_ti.Name = "View_ti";
            this.View_ti.Size = new System.Drawing.Size(135, 52);
            this.View_ti.Style = MetroFramework.MetroColorStyle.Green;
            this.View_ti.TabIndex = 2;
            this.View_ti.Text = "مشاهده سند";
            this.View_ti.UseSelectable = true;
            this.View_ti.Click += new System.EventHandler(this.View_ti_Click);
            // 
            // MoeenCode_lb
            // 
            this.MoeenCode_lb.AutoSize = true;
            this.MoeenCode_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoeenCode_lb.Location = new System.Drawing.Point(797, 283);
            this.MoeenCode_lb.Name = "MoeenCode_lb";
            this.MoeenCode_lb.Size = new System.Drawing.Size(85, 20);
            this.MoeenCode_lb.TabIndex = 3;
            this.MoeenCode_lb.Text = ": کد معین  ";
            // 
            // ColCode_lb
            // 
            this.ColCode_lb.AutoSize = true;
            this.ColCode_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColCode_lb.Location = new System.Drawing.Point(634, 285);
            this.ColCode_lb.Name = "ColCode_lb";
            this.ColCode_lb.Size = new System.Drawing.Size(72, 20);
            this.ColCode_lb.TabIndex = 4;
            this.ColCode_lb.Text = ": کد کل  ";
            // 
            // AccountName_lb
            // 
            this.AccountName_lb.AutoSize = true;
            this.AccountName_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountName_lb.Location = new System.Drawing.Point(306, 283);
            this.AccountName_lb.Name = "AccountName_lb";
            this.AccountName_lb.Size = new System.Drawing.Size(94, 20);
            this.AccountName_lb.TabIndex = 5;
            this.AccountName_lb.Text = ": نام حساب  ";
            // 
            // Bestankar_lb
            // 
            this.Bestankar_lb.AutoSize = true;
            this.Bestankar_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bestankar_lb.Location = new System.Drawing.Point(797, 387);
            this.Bestankar_lb.Name = "Bestankar_lb";
            this.Bestankar_lb.Size = new System.Drawing.Size(85, 20);
            this.Bestankar_lb.TabIndex = 6;
            this.Bestankar_lb.Text = ": بستانکار  ";
            // 
            // Bedehkar_lb
            // 
            this.Bedehkar_lb.AutoSize = true;
            this.Bedehkar_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bedehkar_lb.Location = new System.Drawing.Point(803, 342);
            this.Bedehkar_lb.Name = "Bedehkar_lb";
            this.Bedehkar_lb.Size = new System.Drawing.Size(79, 20);
            this.Bedehkar_lb.TabIndex = 7;
            this.Bedehkar_lb.Text = ": بده کار  ";
            // 
            // MandeHesab_lb
            // 
            this.MandeHesab_lb.AutoSize = true;
            this.MandeHesab_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandeHesab_lb.Location = new System.Drawing.Point(774, 435);
            this.MandeHesab_lb.Name = "MandeHesab_lb";
            this.MandeHesab_lb.Size = new System.Drawing.Size(108, 20);
            this.MandeHesab_lb.TabIndex = 8;
            this.MandeHesab_lb.Text = ": مانده حساب  ";
            // 
            // AccountName_txbox
            // 
            this.AccountName_txbox.Location = new System.Drawing.Point(24, 283);
            this.AccountName_txbox.Multiline = true;
            this.AccountName_txbox.Name = "AccountName_txbox";
            this.AccountName_txbox.Size = new System.Drawing.Size(276, 200);
            this.AccountName_txbox.TabIndex = 9;
            // 
            // MoeenCode_txbox
            // 
            this.MoeenCode_txbox.Location = new System.Drawing.Point(721, 283);
            this.MoeenCode_txbox.Name = "MoeenCode_txbox";
            this.MoeenCode_txbox.Size = new System.Drawing.Size(70, 22);
            this.MoeenCode_txbox.TabIndex = 10;
            // 
            // ColCode_txbox
            // 
            this.ColCode_txbox.Location = new System.Drawing.Point(545, 285);
            this.ColCode_txbox.Name = "ColCode_txbox";
            this.ColCode_txbox.Size = new System.Drawing.Size(70, 22);
            this.ColCode_txbox.TabIndex = 11;
            // 
            // Bedehkar_txbox
            // 
            this.Bedehkar_txbox.Location = new System.Drawing.Point(601, 342);
            this.Bedehkar_txbox.Name = "Bedehkar_txbox";
            this.Bedehkar_txbox.Size = new System.Drawing.Size(190, 22);
            this.Bedehkar_txbox.TabIndex = 12;
            // 
            // Bestankar_txbox
            // 
            this.Bestankar_txbox.Location = new System.Drawing.Point(601, 387);
            this.Bestankar_txbox.Name = "Bestankar_txbox";
            this.Bestankar_txbox.Size = new System.Drawing.Size(190, 22);
            this.Bestankar_txbox.TabIndex = 13;
            // 
            // MandeHesab_txbox
            // 
            this.MandeHesab_txbox.Location = new System.Drawing.Point(401, 435);
            this.MandeHesab_txbox.Name = "MandeHesab_txbox";
            this.MandeHesab_txbox.Size = new System.Drawing.Size(367, 22);
            this.MandeHesab_txbox.TabIndex = 14;
            // 
            // DocumentTotal_lb
            // 
            this.DocumentTotal_lb.AutoSize = true;
            this.DocumentTotal_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentTotal_lb.Location = new System.Drawing.Point(463, 319);
            this.DocumentTotal_lb.Name = "DocumentTotal_lb";
            this.DocumentTotal_lb.Size = new System.Drawing.Size(76, 20);
            this.DocumentTotal_lb.TabIndex = 15;
            this.DocumentTotal_lb.Text = "جمع سند  ";
            // 
            // TotalBedehkar_txbox
            // 
            this.TotalBedehkar_txbox.Location = new System.Drawing.Point(401, 342);
            this.TotalBedehkar_txbox.Name = "TotalBedehkar_txbox";
            this.TotalBedehkar_txbox.Size = new System.Drawing.Size(194, 22);
            this.TotalBedehkar_txbox.TabIndex = 16;
            // 
            // TotalBestankar_txbox
            // 
            this.TotalBestankar_txbox.Location = new System.Drawing.Point(401, 387);
            this.TotalBestankar_txbox.Name = "TotalBestankar_txbox";
            this.TotalBestankar_txbox.Size = new System.Drawing.Size(194, 22);
            this.TotalBestankar_txbox.TabIndex = 17;
            // 
            // NewDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 587);
            this.Controls.Add(this.TotalBestankar_txbox);
            this.Controls.Add(this.TotalBedehkar_txbox);
            this.Controls.Add(this.DocumentTotal_lb);
            this.Controls.Add(this.MandeHesab_txbox);
            this.Controls.Add(this.Bestankar_txbox);
            this.Controls.Add(this.Bedehkar_txbox);
            this.Controls.Add(this.ColCode_txbox);
            this.Controls.Add(this.MoeenCode_txbox);
            this.Controls.Add(this.AccountName_txbox);
            this.Controls.Add(this.MandeHesab_lb);
            this.Controls.Add(this.Bedehkar_lb);
            this.Controls.Add(this.Bestankar_lb);
            this.Controls.Add(this.AccountName_lb);
            this.Controls.Add(this.ColCode_lb);
            this.Controls.Add(this.MoeenCode_lb);
            this.Controls.Add(this.View_ti);
            this.Controls.Add(this.Save_ti);
            this.Controls.Add(this.Document_gbox);
            this.Name = "NewDocument";
            this.Text = "فرم صدور سند";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDocument_FormClosed);
            this.Load += new System.EventHandler(this.NewDocument_Load);
            this.Document_gbox.ResumeLayout(false);
            this.Document_gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Document_gbox;
        private MetroFramework.Controls.MetroLabel DocumentNum_lb;
        private System.Windows.Forms.TextBox DocumentNum_txbox;
        private MetroFramework.Controls.MetroLabel DocumentDetail_lb;
        private MetroFramework.Controls.MetroLabel DocumentDate_lb;
        private System.Windows.Forms.Label Document_lbl;
        private MetroFramework.Controls.MetroLabel DocumentPage_lb;
        private System.Windows.Forms.TextBox DocumentPage_txbox;
        private MetroFramework.Controls.MetroTile Save_ti;
        private MetroFramework.Controls.MetroTile View_ti;
        private System.Windows.Forms.Label MoeenCode_lb;
        private System.Windows.Forms.Label ColCode_lb;
        private System.Windows.Forms.Label AccountName_lb;
        private System.Windows.Forms.Label Bestankar_lb;
        private System.Windows.Forms.Label Bedehkar_lb;
        private System.Windows.Forms.Label MandeHesab_lb;
        private System.Windows.Forms.TextBox AccountName_txbox;
        private System.Windows.Forms.TextBox MoeenCode_txbox;
        private System.Windows.Forms.TextBox ColCode_txbox;
        private System.Windows.Forms.TextBox Bedehkar_txbox;
        private System.Windows.Forms.TextBox Bestankar_txbox;
        private System.Windows.Forms.TextBox MandeHesab_txbox;
        private MetroFramework.Controls.MetroDateTime DocumentDate_DateTime;
        private System.Windows.Forms.Label DocumentTotal_lb;
        private System.Windows.Forms.TextBox TotalBedehkar_txbox;
        private System.Windows.Forms.TextBox TotalBestankar_txbox;
    }
}