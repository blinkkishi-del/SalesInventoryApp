using BusinessLogic.Controller;
using Model;
using System.Data;
using System.Drawing.Drawing2D;

namespace UI
{
    public partial class AdminDashboard : Form
    {
        private readonly ProductController productController;
        private readonly SalesController salesController;
        private readonly StockController stockController = new StockController();
        internal UserModel CurrentUser;

        internal Action<string, string>? ReorderRequested;

        private readonly List<(string Label, decimal Amount)> _chartData = new();

        public AdminDashboard()
        {
            InitializeComponent();
            productController = new ProductController();
            salesController = new SalesController();

            GridFormatHelper.ApplyModernStyle(dgridLowStock);
            GridFormatHelper.ApplyModernStyle(dgRecentSales);
            GridFormatHelper.ApplyModernStyle(dgRecentStock);

            foreach (Control c in new Control[] { panel2, lblLowStock, label2, lblLowStockSub, badgeLowStock, iconPictureBox1 })
            {
                c.Cursor = Cursors.Hand;
                c.Click += (s, e) => FocusLowStockList();
            }

            panelChart.Paint += PanelChart_Paint;

            foreach (Control card in new Control[] { panel1, panel2, panel4 }) RoundCorners(card, 14);
            foreach (Control badge in new Control[] { badgeInventory, badgeLowStock, badgeSales }) RoundCorners(badge, 28);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        public void LoadDashboardData()
        {
            lblTotalInventory.Text = productController.GetTotalInventory().ToString("N0");
            lblInventorySub.Text = $"units across {productController.GetAllProducts().Count:N0} products";

            var lowStock = productController.GetLowStockProducts(10);
            lblLowStock.Text = lowStock.Count.ToString();
            lblLowStockSub.Text = lowStock.Count == 0 ? "everything is well stocked" : "products at 10 units or below";
            dgridLowStock.DataSource = null;
            dgridLowStock.DataSource = lowStock;
            FormatLowStockGrid();

            decimal todaySales = salesController.GetTotalSalesToday();
            lblTotalSalesToday.Text = $"₱{todaySales:N2}";
            int salesCount = salesController.GetSalesCountByDate(DateTime.Today);
            lblSalesSub.Text = salesCount == 1 ? "1 sale today" : $"{salesCount:N0} sales today";
            LoadRecentActivity();

            LoadChartData();
        }

        private static void RoundCorners(Control control, int radius)
        {
            void Apply()
            {
                if (control.Width <= 0 || control.Height <= 0) return;
                int d = Math.Min(radius * 2, Math.Min(control.Width, control.Height));
                using var path = new GraphicsPath();
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(control.Width - d, 0, d, d, 270, 90);
                path.AddArc(control.Width - d, control.Height - d, d, d, 0, 90);
                path.AddArc(0, control.Height - d, d, d, 90, 90);
                path.CloseFigure();
                control.Region = new Region(path);
            }
            Apply();
            control.Resize += (s, e) => Apply();
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
            GridFormatHelper.HideColumns(dgridLowStock, "ProductId", "Brand", "Category");
            GridFormatHelper.SetHeaders(dgridLowStock, ("ProductName", "Product"), ("Quantity", "Stock"), ("Amount", "Price"));
            GridFormatHelper.FormatCurrencyColumns(dgridLowStock, "Amount");
            GridFormatHelper.SetColumnFillWeights(dgridLowStock, ("ProductName", 30), ("Model", 14), ("Supplier", 26),
                ("Quantity", 11), ("Amount", 19));
            if (dgridLowStock.Columns.Contains("Quantity"))
            {
                dgridLowStock.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgridLowStock.Columns["Quantity"].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void LoadRecentActivity()
        {
            dgRecentSales.DataSource = null;
            dgRecentSales.DataSource = salesController.GetRecentSales(5);
            GridFormatHelper.SetHeaders(dgRecentSales, ("ReceiptNo", "Receipt"), ("SalesDate", "Date"),
                ("SoldBy", "Cashier"), ("TotalAmount", "Total"));
            GridFormatHelper.FormatCurrencyColumns(dgRecentSales, "TotalAmount");
            if (dgRecentSales.Columns.Contains("SalesDate"))
                dgRecentSales.Columns["SalesDate"].DefaultCellStyle.Format = "MM/dd";
            GridFormatHelper.SetColumnFillWeights(dgRecentSales, ("ReceiptNo", 28), ("SalesDate", 14), ("SoldBy", 20),
                ("Items", 12), ("TotalAmount", 26));

            dgRecentStock.DataSource = null;
            dgRecentStock.DataSource = stockController.GetRecentMovements(5);
            GridFormatHelper.HideColumns(dgRecentStock, "ReferenceNo");
            GridFormatHelper.SetHeaders(dgRecentStock, ("ProductName", "Product"));
            if (dgRecentStock.Columns.Contains("When"))
                dgRecentStock.Columns["When"].DefaultCellStyle.Format = "MM/dd hh:mm tt";
            if (dgRecentStock.Columns.Contains("Qty"))
            {
                dgRecentStock.Columns["Qty"].DefaultCellStyle.Format = "+0;-0;0";
                dgRecentStock.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            GridFormatHelper.SetColumnFillWeights(dgRecentStock, ("When", 24), ("Activity", 18), ("ProductName", 36),
                ("Qty", 9), ("By", 13));
        }

        private void FocusLowStockList()
        {
            dgridLowStock.Focus();
            if (dgridLowStock.Rows.Count > 0)
            {
                dgridLowStock.CurrentCell = dgridLowStock.Rows[0].Cells[dgridLowStock.Columns["ProductName"].Index];
                dgridLowStock.Rows[0].Selected = true;
            }
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            if (dgridLowStock.CurrentRow?.DataBoundItem is not ProductDetailsModel product)
            {
                MessageBox.Show("Select a low-stock product to reorder.", "Reorder",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ReorderRequested?.Invoke(product.ProductId, product.Supplier);
        }

        private void dgridLowStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnReorder_Click(sender, e);
        }
    }
}
