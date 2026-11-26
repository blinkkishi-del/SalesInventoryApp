namespace UI
{
    partial class POSRecord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabRecords = new TabControl();
            tabTopSelling = new TabPage();
            reportTopSelling = new ReportTab();
            tabSoldItems = new TabPage();
            reportSoldItems = new ReportTab();
            tabCritical = new TabPage();
            reportCritical = new ReportTab();
            tabInventory = new TabPage();
            reportInventory = new ReportTab();
            tabStockIn = new TabPage();
            reportStockIn = new ReportTab();
            tabRecords.SuspendLayout();
            tabTopSelling.SuspendLayout();
            tabSoldItems.SuspendLayout();
            tabCritical.SuspendLayout();
            tabInventory.SuspendLayout();
            tabStockIn.SuspendLayout();
            SuspendLayout();
            //
            // tabRecords
            //
            tabRecords.Controls.Add(tabTopSelling);
            tabRecords.Controls.Add(tabSoldItems);
            tabRecords.Controls.Add(tabCritical);
            tabRecords.Controls.Add(tabInventory);
            tabRecords.Controls.Add(tabStockIn);
            tabRecords.Dock = DockStyle.Fill;
            tabRecords.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tabRecords.Name = "tabRecords";
            tabRecords.Padding = new Point(14, 5);
            tabRecords.SelectedIndex = 0;
            tabRecords.TabIndex = 0;
            //
            // tabTopSelling
            //
            tabTopSelling.BackColor = Color.FromArgb(34, 33, 74);
            tabTopSelling.Controls.Add(reportTopSelling);
            tabTopSelling.Name = "tabTopSelling";
            tabTopSelling.Text = "Top Selling";
            //
            // reportTopSelling
            //
            reportTopSelling.Dock = DockStyle.Fill;
            reportTopSelling.Name = "reportTopSelling";
            //
            // tabSoldItems
            //
            tabSoldItems.BackColor = Color.FromArgb(34, 33, 74);
            tabSoldItems.Controls.Add(reportSoldItems);
            tabSoldItems.Name = "tabSoldItems";
            tabSoldItems.Text = "Sold Items";
            //
            // reportSoldItems
            //
            reportSoldItems.Dock = DockStyle.Fill;
            reportSoldItems.Name = "reportSoldItems";
            //
            // tabCritical
            //
            tabCritical.BackColor = Color.FromArgb(34, 33, 74);
            tabCritical.Controls.Add(reportCritical);
            tabCritical.Name = "tabCritical";
            tabCritical.Text = "Critical Stocks";
            //
            // reportCritical
            //
            reportCritical.Dock = DockStyle.Fill;
            reportCritical.Name = "reportCritical";
            //
            // tabInventory
            //
            tabInventory.BackColor = Color.FromArgb(34, 33, 74);
            tabInventory.Controls.Add(reportInventory);
            tabInventory.Name = "tabInventory";
            tabInventory.Text = "Inventory List";
            //
            // reportInventory
            //
            reportInventory.Dock = DockStyle.Fill;
            reportInventory.Name = "reportInventory";
            //
            // tabStockIn
            //
            tabStockIn.BackColor = Color.FromArgb(34, 33, 74);
            tabStockIn.Controls.Add(reportStockIn);
            tabStockIn.Name = "tabStockIn";
            tabStockIn.Text = "Stock-In History";
            //
            // reportStockIn
            //
            reportStockIn.Dock = DockStyle.Fill;
            reportStockIn.Name = "reportStockIn";
            //
            // POSRecord
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(tabRecords);
            Name = "POSRecord";
            Text = "POS Record";
            tabRecords.ResumeLayout(false);
            tabTopSelling.ResumeLayout(false);
            tabSoldItems.ResumeLayout(false);
            tabCritical.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            tabStockIn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabRecords;
        private TabPage tabTopSelling;
        private ReportTab reportTopSelling;
        private TabPage tabSoldItems;
        private ReportTab reportSoldItems;
        private TabPage tabCritical;
        private ReportTab reportCritical;
        private TabPage tabInventory;
        private ReportTab reportInventory;
        private TabPage tabStockIn;
        private ReportTab reportStockIn;
    }
}
