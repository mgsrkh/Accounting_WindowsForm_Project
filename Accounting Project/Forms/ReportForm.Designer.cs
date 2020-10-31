namespace Accounting_Project
{
    partial class Report
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.View_bt = new MetroFramework.Controls.MetroButton();
            this.Print_bt = new MetroFramework.Controls.MetroButton();
            this.Report_bt = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(23, 115);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(772, 494);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // View_bt
            // 
            this.View_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.View_bt.Location = new System.Drawing.Point(656, 47);
            this.View_bt.Name = "View_bt";
            this.View_bt.Size = new System.Drawing.Size(139, 62);
            this.View_bt.TabIndex = 1;
            this.View_bt.Text = "مشاهده گزارش";
            this.View_bt.UseSelectable = true;
            this.View_bt.Click += new System.EventHandler(this.View_bt_Click);
            // 
            // Print_bt
            // 
            this.Print_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Print_bt.Location = new System.Drawing.Point(510, 47);
            this.Print_bt.Name = "Print_bt";
            this.Print_bt.Size = new System.Drawing.Size(140, 62);
            this.Print_bt.TabIndex = 2;
            this.Print_bt.Text = "پرینت";
            this.Print_bt.UseSelectable = true;
            this.Print_bt.Click += new System.EventHandler(this.Print_bt_Click);
            // 
            // Report_bt
            // 
            this.Report_bt.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Report_bt.Location = new System.Drawing.Point(369, 47);
            this.Report_bt.Name = "Report_bt";
            this.Report_bt.Size = new System.Drawing.Size(135, 62);
            this.Report_bt.TabIndex = 3;
            this.Report_bt.Text = "ذخیره";
            this.Report_bt.UseSelectable = true;
            this.Report_bt.Click += new System.EventHandler(this.Report_bt_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 632);
            this.Controls.Add(this.Report_bt);
            this.Controls.Add(this.Print_bt);
            this.Controls.Add(this.View_bt);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report";
            this.Text = "فرم گزارش مانده حساب";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroButton View_bt;
        private MetroFramework.Controls.MetroButton Print_bt;
        private MetroFramework.Controls.MetroButton Report_bt;
    }
}