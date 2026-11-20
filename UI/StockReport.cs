using BusinessLogic.Controller;
using System.Data;
using System.Drawing.Printing;

namespace UI
{
    public partial class StockReport : Form
    {

        private readonly StockController controller = new StockController();

        public StockReport()
        {
            InitializeComponent();
            this.Load += StockReport_Load;
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            try
            {
                dgProducts.Visible = true;

                dgProducts.ReadOnly = true;
                dgProducts.AllowUserToAddRows = false;
                dgProducts.AllowUserToDeleteRows = false;
                dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgProducts.MultiSelect = false;

                LoadStockSummary();
                LoadStockData("");
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing stock report: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            List<string> categories = new List<string>()
     {
         "All","Kitchen", "Cleaning", "Laundry", "Climate", "Personal Care", "Outdoor"
     };

            cbProductsCategory.Items.Clear();
            cbProductsCategory.Items.AddRange(categories.ToArray());
            cbProductsCategory.SelectedIndex = 0;

            cbProductsCategory.SelectedIndexChanged += cbProductsCategory_SelectedIndexChanged;
        }





        private void LoadStockSummary()
        {
            try
            {
                lblNumberofstocks.Text = controller.GetTotalInventory().ToString();
                lblLowStock.Text = controller.GetLowStockCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock summary: " + ex.Message);
            }
        }

        private void FilterProductsById(string productId)
        {
            try
            {
                DataTable dt = controller.GetStockByProductId(productId);

                if (dt == null || dt.Rows.Count == 0)
                {
                    dgProducts.DataSource = null;
                    return;
                }

                dgProducts.DataSource = dt;
                dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock data: " + ex.Message);
            }
        }

        private void LoadStockData(string productId)
        {
            FilterProductsById(productId);
        }

        private string GetCellValue(DataGridViewRow row, string[] keys, string defaultValue = "N/A")
        {
            foreach (DataGridViewColumn col in row.DataGridView.Columns)
            {
                if (keys.Any(k =>
                    col.Name.Equals(k, StringComparison.OrdinalIgnoreCase) ||
                    col.DataPropertyName.Equals(k, StringComparison.OrdinalIgnoreCase) ||
                    col.HeaderText.Equals(k, StringComparison.OrdinalIgnoreCase)))
                {
                    object val = row.Cells[col.Index].Value;
                    return val?.ToString() ?? defaultValue;
                }
            }
            return defaultValue;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgProducts.Rows.Count == 0)
            {
                MessageBox.Show("No stock records available to print.");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = false;

            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10, FontStyle.Regular);
            Font tableHeaderFont = new Font("Arial", 9, FontStyle.Bold);
            Font tableFont = new Font("Arial", 9);
            int lineHeight = tableFont.Height + 6;

            int totalRows = dgProducts.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

            int tableHeight = (totalRows + 1) * lineHeight;
            int pageHeight = headerFont.Height + subHeaderFont.Height * 2 + 10 + tableHeight + 50;

            PaperSize paperSize = new PaperSize("Custom", 850, pageHeight);
            printDoc.DefaultPageSettings.PaperSize = paperSize;
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

                ev.Graphics.DrawString("STOCK REPORT", subHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += subHeaderFont.Height + 2;

                ev.Graphics.DrawString($"Generated: {DateTime.Now:MMMM dd, yyyy hh:mm tt}", subHeaderFont, Brushes.Black,
                    ev.MarginBounds.Left + ev.MarginBounds.Width / 2, y, center);
                y += subHeaderFont.Height + 10;

                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 12;

                float col1 = left;
                float col2 = left + 200;
                float col3 = left + 350;
                float col4 = left + 500;
                float col5 = left + 650;

                ev.Graphics.DrawString("Product Name", tableHeaderFont, Brushes.Black, col1, y);
                ev.Graphics.DrawString("Curr Stock", tableHeaderFont, Brushes.Black, col2, y);
                ev.Graphics.DrawString("Qty Sold", tableHeaderFont, Brushes.Black, col3, y);
                ev.Graphics.DrawString("Prev Stock", tableHeaderFont, Brushes.Black, col4, y);
                ev.Graphics.DrawString("Category", tableHeaderFont, Brushes.Black, col5, y);

                y += lineHeight;
                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 8;

                for (; currentRow < dgProducts.Rows.Count; currentRow++)
                {
                    DataGridViewRow row = dgProducts.Rows[currentRow];
                    if (row.IsNewRow) continue;

                    string name = GetCellValue(row, new[] { "ProductName", "Name", "ItemName" });
                    string curr = GetCellValue(row, new[] { "Quantity", "CurrentStock", "Stock" }, "0");
                    string sold = GetCellValue(row, new[] { "QuantitySold", "QtySold" }, "0");
                    string prev = GetCellValue(row, new[] { "PreviousStock", "PrevStock" }, "0");
                    string cat = GetCellValue(row, new[] { "Category", "Cat" });

                    ev.Graphics.DrawString(name, tableFont, Brushes.Black, col1, y);
                    ev.Graphics.DrawString(curr, tableFont, Brushes.Black, col2, y);
                    ev.Graphics.DrawString(sold, tableFont, Brushes.Black, col3, y);
                    ev.Graphics.DrawString(prev, tableFont, Brushes.Black, col4, y);
                    ev.Graphics.DrawString(cat, tableFont, Brushes.Black, col5, y);

                    y += lineHeight;
                }

                y += 10;
                ev.Graphics.DrawLine(Pens.Black, left, y, left + ev.MarginBounds.Width, y);
                y += 10;

                ev.Graphics.DrawString("END OF REPORT", tableHeaderFont, Brushes.Black,
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


        private void cbProductsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbProductsCategory.SelectedItem.ToString();

            if (selectedCategory == "All")
                LoadStockData("");
            else
                LoadStockDataByCategory(selectedCategory);
        }
        private void LoadStockDataByCategory(string category)
        {
            try
            {
                DataTable dtAll = controller.LoadStockData();

                if (category != "All")
                {
                    DataView dv = dtAll.DefaultView;
                    dv.RowFilter = $"Category = '{category.Replace("'", "''")}'";
                    dgProducts.DataSource = dv.ToTable();
                }
                else
                {
                    dgProducts.DataSource = dtAll;
                }

                dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock data: " + ex.Message);
            }
        }
    }
}
