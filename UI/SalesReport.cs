using BusinessLogic.Controller;
using System.Data;
using System.Drawing.Printing;


namespace UI
{
    public partial class SalesReport : Form
    {

        private readonly SalesController salesController;


        public SalesReport()
        {
            InitializeComponent();
            salesController = new SalesController();

            string[] months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < 12; i++)
            {
                cbDateMonth.Items.Add(months[i]);
            }

            cbDateMonth.SelectedIndexChanged += ComboDate_SelectedIndexChanged;

            if (!this.Controls.Contains(cbDateMonth))
                this.Controls.Add(cbDateMonth);

            cbDateMonth.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void ComboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDateMonth.SelectedIndex >= 0)
            {
                int selectedMonth = cbDateMonth.SelectedIndex + 1;
                LoadSalesDataByMonth(selectedMonth);
            }
        }


        private void SalesReport_Load(object sender, EventArgs e)
        {
            cbDateMonth.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void LoadSalesDataByMonth(int month)
        {
            try
            {
                DataTable dt = salesController.GetAllSales();

                if (dt == null || dt.Rows.Count == 0)
                {
                    dgList.DataSource = null;
                    MessageBox.Show($"No sales records found for month {month}.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var filteredRows = dt.AsEnumerable()
                    .Where(row => Convert.ToDateTime(row["SalesDate"]).Month == month)
                    .ToList();

                if (!filteredRows.Any())
                {
                    dgList.DataSource = null;
                    MessageBox.Show($"No sales records found for {cbDateMonth.SelectedItem}.",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable filteredDt = dt.Clone();
                foreach (var row in filteredRows)
                    filteredDt.ImportRow(row);

                dgList.DataSource = filteredDt;
                dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgList.MultiSelect = false;

                if (dgList.Rows.Count > 0)
                    dgList.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data:\n" + ex.Message, "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetTotalSalesForMonth(int month)
        {
            DataTable dt = salesController.GetAllSales();
            var filteredRows = dt.AsEnumerable()
                .Where(row => Convert.ToDateTime(row["SalesDate"]).Month == month);

            decimal total = 0;
            foreach (var row in filteredRows)
                total += Convert.ToDecimal(row["TotalPrice"]);

            return total;
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                if (cbDateMonth.SelectedIndex < 0) return;
                int selectedMonth = cbDateMonth.SelectedIndex + 1;

                DataTable dt = salesController.SearchSales(keyword);

                var filteredRows = dt.AsEnumerable()
                    .Where(row => Convert.ToDateTime(row["SalesDate"]).Month == selectedMonth)
                    .ToList();

                DataTable filteredDt = dt.Clone();
                foreach (var row in filteredRows)
                    filteredDt.ImportRow(row);

                dgList.DataSource = null;
                dgList.DataSource = filteredDt;

                dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgList.MultiSelect = false;

                if (filteredDt.Rows.Count > 0)
                    dgList.Rows[0].Selected = true;
                else
                    MessageBox.Show($"No sales records found matching '{keyword}' for {cbDateMonth.SelectedItem}.",
                        "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtSearch.Text = "";
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbDateMonth.SelectedIndex < 0 || dgList.Rows.Count == 0)
            {
                MessageBox.Show("No sales records to print for the selected month.",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int month = cbDateMonth.SelectedIndex + 1;
            decimal totalSales = GetTotalSalesForMonth(month);

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false;

            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10, FontStyle.Regular);
            Font tableHeaderFont = new Font("Arial", 9, FontStyle.Bold);
            Font tableFont = new Font("Arial", 9);

            int lineHeight = tableFont.Height + 6;

            int totalRows = dgList.Rows.Cast<DataGridViewRow>()
                                           .Count(r => !r.IsNewRow);

            int tableHeight = (totalRows + 1) * lineHeight;
            int pageHeight = headerFont.Height + subHeaderFont.Height * 2 +
                             10 + tableHeight + 100;

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

                ev.Graphics.DrawString("SALES REPORT", subHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += subHeaderFont.Height + 2;

                ev.Graphics.DrawString($"MONTH: {cbDateMonth.SelectedItem}", subHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += subHeaderFont.Height + 2;

                ev.Graphics.DrawString($"Generated: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", subHeaderFont,
                    Brushes.Black, ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += subHeaderFont.Height + 10;

                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 12;

                float col1 = left;
                float col2 = left + 300;
                float col3 = left + 450;

                ev.Graphics.DrawString("Product Name", tableHeaderFont, Brushes.Black, col1, y);
                ev.Graphics.DrawString("Quantity", tableHeaderFont, Brushes.Black, col2, y);
                ev.Graphics.DrawString("Total Price", tableHeaderFont, Brushes.Black, col3, y);

                y += lineHeight;
                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 8;

                for (; currentRow < dgList.Rows.Count; currentRow++)
                {
                    DataGridViewRow row = dgList.Rows[currentRow];
                    if (row.IsNewRow) continue;

                    string name = row.Cells["ProductName"].Value?.ToString() ?? "N/A";
                    string qty = row.Cells["Quantity"].Value?.ToString() ?? "0";
                    string price = Convert.ToDecimal(row.Cells["TotalPrice"].Value).ToString("N2");

                    ev.Graphics.DrawString(name, tableFont, Brushes.Black, col1, y);
                    ev.Graphics.DrawString(qty, tableFont, Brushes.Black, col2, y);
                    ev.Graphics.DrawString("₱" + price, tableFont, Brushes.Black, col3, y);

                    y += lineHeight;
                }

                y += 10;
                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 10;

                ev.Graphics.DrawString($"TOTAL SALES: ₱{totalSales:N2}", tableHeaderFont,
                    Brushes.Black, left + 350, y);

                y += 25;

                ev.Graphics.DrawString("END OF SALES REPORT", tableHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);

                ev.HasMorePages = false;
            };

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 900,
                Height = 700
            };
            preview.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cbDateMonth.SelectedIndex >= 0)
                LoadSalesDataByMonth(cbDateMonth.SelectedIndex + 1);
        }
    }
}
