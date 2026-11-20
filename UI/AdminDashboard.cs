using BusinessLogic.Controller;
using System.Drawing.Printing;


namespace UI
{
    public partial class AdminDashboard : Form
    {

        private readonly ProductController productController;
        private readonly SalesController salesController;

        public AdminDashboard()
        {
            InitializeComponent();
            productController = new ProductController();
            salesController = new SalesController();
            LoadDashboardData();
            dgridLowStock.ReadOnly = true;
            dgridLowStock.AllowUserToAddRows = false;
            dgridLowStock.AllowUserToDeleteRows = false;
            dgridLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLowStock.MultiSelect = false;

            foreach (DataGridViewRow row in dgridLowStock.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.ForeColor = Color.Black;
                    cell.Style.BackColor = Color.White;
                }
            }
        }


        public void ExpandColumns(DataGridView source, bool sizable = true)
        {
            foreach (DataGridViewColumn col in source.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadDashboardData()
        {
            var totalInventory = productController.GetTotalInventory();
            lblTotalInventory.Text = totalInventory.ToString();

            var lowStock = productController.GetLowStockProducts(10);
            dgridLowStock.DataSource = lowStock;
            lblLowStock.Text = lowStock.Count.ToString();

            var totalSales = salesController.GetTotalSalesToday();
            lblTotalSalesToday.Text = ((int)totalSales).ToString();


        }

        private void btnPrintLowStock_Click(object sender, EventArgs e)
        {

            if (dgridLowStock.Rows.Count == 0)
            {
                MessageBox.Show("No low stock records available to print.");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false;

            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10, FontStyle.Regular);
            Font tableHeaderFont = new Font("Arial", 9, FontStyle.Bold);
            Font tableFont = new Font("Arial", 9);
            int lineHeight = tableFont.Height + 6;


            int totalRows = 0;
            foreach (DataGridViewRow row in dgridLowStock.Rows)
            {
                if (!row.IsNewRow)
                    totalRows++;
            }

            int tableHeight = (totalRows + 1) * lineHeight;
            int pageHeight = headerFont.Height + subHeaderFont.Height * 2 + 10 + tableHeight + 50;


            PaperSize receiptSize = new PaperSize("Custom", 850, pageHeight);
            printDoc.DefaultPageSettings.PaperSize = receiptSize;
            printDoc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);

            int currentRow = 0;

            printDoc.PrintPage += (s, ev) =>
            {
                float left = ev.MarginBounds.Left;
                float y = ev.MarginBounds.Top;

                StringFormat center = new StringFormat { Alignment = StringAlignment.Center };


                ev.Graphics.DrawString("Homexa", headerFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += headerFont.Height + 5;

                ev.Graphics.DrawString("LOW STOCK REPORT", subHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += subHeaderFont.Height + 2;

                ev.Graphics.DrawString($"Generated: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", subHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += subHeaderFont.Height + 10;

                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 12;


                float col1 = left;
                float col2 = left + 100;
                float col3 = left + 350;
                float col4 = left + 550;
                float col5 = left + 700;
                float col6 = left + 750;

                ev.Graphics.DrawString("Prod ID", tableHeaderFont, Brushes.Black, col1, y);
                ev.Graphics.DrawString("Product Name", tableHeaderFont, Brushes.Black, col2, y);
                ev.Graphics.DrawString("Category", tableHeaderFont, Brushes.Black, col3, y);
                ev.Graphics.DrawString("Supplier", tableHeaderFont, Brushes.Black, col4, y);
                ev.Graphics.DrawString("Qty", tableHeaderFont, Brushes.Black, col5, y);
                ev.Graphics.DrawString("Amount", tableHeaderFont, Brushes.Black, col6, y);

                y += lineHeight;
                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 8;


                for (; currentRow < dgridLowStock.Rows.Count; currentRow++)
                {
                    DataGridViewRow row = dgridLowStock.Rows[currentRow];
                    if (row.IsNewRow) continue;

                    ev.Graphics.DrawString(row.Cells["ProductId"].Value?.ToString(), tableFont, Brushes.Black, col1, y);
                    ev.Graphics.DrawString(row.Cells["ProductName"].Value?.ToString(), tableFont, Brushes.Black, col2, y);
                    ev.Graphics.DrawString(row.Cells["Category"].Value?.ToString(), tableFont, Brushes.Black, col3, y);
                    ev.Graphics.DrawString(row.Cells["Supplier"].Value?.ToString(), tableFont, Brushes.Black, col4, y);
                    ev.Graphics.DrawString(row.Cells["Quantity"].Value?.ToString(), tableFont, Brushes.Black, col5, y);
                    ev.Graphics.DrawString(row.Cells["Amount"].Value?.ToString(), tableFont, Brushes.Black, col6, y);

                    y += lineHeight;
                }


                y += 10;
                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 10;
                ev.Graphics.DrawString("END OF REPORT", tableHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);

                ev.HasMorePages = false;
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.Width = 900;
            preview.Height = 700;
            preview.ShowDialog();

        }


    }
}
