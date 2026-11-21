using BusinessLogic.Controller;
using Model;
using System.Data;
using System.Drawing.Printing;

namespace UI
{
    public partial class AdminDashboard : Form
    {
        private readonly ProductController productController;
        private readonly SalesController salesController;
        internal UserModel CurrentUser;

        private readonly List<(string Label, decimal Amount)> _chartData = new();

        public AdminDashboard()
        {
            InitializeComponent();
            productController = new ProductController();
            salesController = new SalesController();

            dgridLowStock.ReadOnly = true;
            dgridLowStock.AllowUserToAddRows = false;
            dgridLowStock.AllowUserToDeleteRows = false;
            dgridLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLowStock.MultiSelect = false;

            dgridTopSellers.ReadOnly = true;
            dgridTopSellers.AllowUserToAddRows = false;
            dgridTopSellers.AllowUserToDeleteRows = false;
            dgridTopSellers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridTopSellers.MultiSelect = false;

            dtpSalesLookup.Value = DateTime.Today;
            dtpSalesLookup.Format = DateTimePickerFormat.Short;

            panelChart.Paint += PanelChart_Paint;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        public void LoadDashboardData()
        {
            lblTotalInventory.Text = productController.GetTotalInventory().ToString("N0");

            var lowStock = productController.GetLowStockProducts(10);
            lblLowStock.Text = lowStock.Count.ToString();
            dgridLowStock.DataSource = null;
            dgridLowStock.DataSource = lowStock;
            FormatLowStockGrid();

            decimal todaySales = salesController.GetTotalSalesToday();
            lblTotalSalesToday.Text = $"₱{todaySales:N2}";

            LoadSalesForDate(dtpSalesLookup.Value.Date);

            dgridTopSellers.DataSource = null;
            dgridTopSellers.DataSource = salesController.GetTop5Sellers();
            FormatTopSellersGrid();

            LoadChartData();
        }

        private void LoadSalesForDate(DateTime date)
        {
            decimal amount = salesController.GetTotalSalesByDate(date);
            lblSalesForDate.Text = $"₱{amount:N2}";
        }

        private void LoadChartData()
        {
            _chartData.Clear();
            DataTable dt = salesController.GetLast7DaysSales();

            for (int i = 6; i >= 0; i--)
            {
                DateTime day = DateTime.Today.AddDays(-i);
                string label = day.ToString("MM/dd");
                decimal amount = 0;

                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToDateTime(row["SaleDay"]).Date == day.Date)
                    {
                        amount = Convert.ToDecimal(row["DayTotal"]);
                        break;
                    }
                }
                _chartData.Add((label, amount));
            }

            panelChart.Invalidate();
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {
            if (_chartData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = panelChart.Width;
            int h = panelChart.Height;
            int padLeft = 70, padBottom = 36, padTop = 20, padRight = 16;

            int chartW = w - padLeft - padRight;
            int chartH = h - padBottom - padTop;

            decimal maxVal = _chartData.Max(d => d.Amount);
            if (maxVal == 0) maxVal = 1;


            using var gridPen = new Pen(Color.FromArgb(60, 255, 255, 255));
            for (int line = 0; line <= 4; line++)
            {
                float yPos = padTop + chartH - (chartH * line / 4f);
                g.DrawLine(gridPen, padLeft, yPos, padLeft + chartW, yPos);

                decimal yVal = maxVal * line / 4;
                string yLabel = yVal >= 1000
                    ? $"₱{yVal / 1000:N0}k"
                    : $"₱{yVal:N0}";
                g.DrawString(yLabel, new Font("Segoe UI", 7F), Brushes.Silver,
                    2, yPos - 7);
            }

            int barCount = _chartData.Count;
            float slotW = chartW / (float)barCount;
            float barW = slotW * 0.55f;

            using var barBrush = new SolidBrush(Color.FromArgb(172, 126, 241));
            using var todayBrush = new SolidBrush(Color.FromArgb(249, 118, 176));
            using var labelBrush = new SolidBrush(Color.Silver);
            var labelFont = new Font("Segoe UI", 7.5F);
            var valFont = new Font("Segoe UI", 7F, FontStyle.Bold);

            for (int i = 0; i < barCount; i++)
            {
                var (label, amount) = _chartData[i];
                float barH = chartH * (float)(amount / maxVal);
                float x = padLeft + i * slotW + (slotW - barW) / 2f;
                float y = padTop + chartH - barH;

                bool isToday = (i == barCount - 1);
                g.FillRectangle(isToday ? todayBrush : barBrush, x, y, barW, barH);

                g.DrawString(label, labelFont, labelBrush,
                    x + barW / 2f - 14, padTop + chartH + 4);

                if (barH > 18)
                {
                    string valLabel = amount >= 1000
                        ? $"₱{amount / 1000:N0}k"
                        : $"₱{amount:N0}";
                    g.DrawString(valLabel, valFont, Brushes.White,
                        x + barW / 2f - 14, y - 14);
                }
            }

            using var axisPen = new Pen(Color.FromArgb(100, 255, 255, 255));
            g.DrawLine(axisPen, padLeft, padTop + chartH, padLeft + chartW, padTop + chartH);
        }

        private void FormatLowStockGrid()
        {
            if (dgridLowStock.Columns.Contains("ProductId"))
                dgridLowStock.Columns["ProductId"].Visible = false;
            if (dgridLowStock.Columns.Contains("Supplier"))
                dgridLowStock.Columns["Supplier"].Visible = false;
            if (dgridLowStock.Columns.Contains("ProductName"))
                dgridLowStock.Columns["ProductName"].HeaderText = "Product";
            if (dgridLowStock.Columns.Contains("Quantity"))
                dgridLowStock.Columns["Quantity"].HeaderText = "Stock";
            if (dgridLowStock.Columns.Contains("Amount"))
                dgridLowStock.Columns["Amount"].HeaderText = "Price";
            dgridLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatTopSellersGrid()
        {
            if (dgridTopSellers.Columns.Contains("ProductName"))
                dgridTopSellers.Columns["ProductName"].HeaderText = "Product";
            if (dgridTopSellers.Columns.Contains("TotalQtySold"))
                dgridTopSellers.Columns["TotalQtySold"].HeaderText = "Units Sold";
            if (dgridTopSellers.Columns.Contains("TotalRevenue"))
                dgridTopSellers.Columns["TotalRevenue"].HeaderText = "Revenue";
            dgridTopSellers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void btnLookupSales_Click(object sender, EventArgs e)
        {
            LoadSalesForDate(dtpSalesLookup.Value.Date);
        }

        private void btnPrintLowStock_Click(object sender, EventArgs e)
        {
            if (dgridLowStock.Rows.Count == 0)
            {
                MessageBox.Show("No low stock records to print.");
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
                if (!row.IsNewRow) totalRows++;

            int tableHeight = (totalRows + 1) * lineHeight;
            int pageHeight = headerFont.Height + subHeaderFont.Height * 2 + 10 + tableHeight + 50;

            printDoc.DefaultPageSettings.PaperSize = new PaperSize("Custom", 850, pageHeight);
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

                float col1 = left, col2 = left + 100, col3 = left + 350,
                      col4 = left + 550, col5 = left + 700, col6 = left + 750;

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

            var preview = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 900,
                Height = 700
            };
            preview.ShowDialog();
        }

        private void dgridLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
