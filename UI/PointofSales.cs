using BusinessLogic.Controller;
using Model;
using System.Drawing.Printing;

namespace UI
{
    public partial class PointofSales : Form
    {

        private readonly OrderProductController orderController;
        private readonly ProductController productController;
        private readonly SalesController salesController;
        private List<ProductDetailsModel> productList;
        internal UserModel CurrentUser;



        public PointofSales()
        {
            InitializeComponent();
            orderController = new OrderProductController();
            productController = new ProductController();
            salesController = new SalesController();
            txtPay.TextChanged += txtPay_TextChanged;
            datetpDate.Enabled = false;

        }

        private void POS_Load(object sender, EventArgs e)
        {
            LoadProducts();
            RefreshReceiptGrid();
            UpdateTotalAndChange();
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgViewReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgViewReceipt.MultiSelect = false;
            dgViewReceipt.ReadOnly = true;
            dgViewReceipt.AllowUserToAddRows = false;
            dgViewReceipt.AllowUserToDeleteRows = false;
        }

        private void LoadProducts()
        {
            try
            {
                productList = productController.GetProductsOrderedByStock();
                dgProducts.DataSource = null;
                dgProducts.DataSource = productList;
                FormatProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatProductGrid()
        {
            if (dgProducts.Columns.Contains("ProductId"))
                dgProducts.Columns["ProductId"].Visible = false;
            if (dgProducts.Columns.Contains("Supplier"))
                dgProducts.Columns["Supplier"].Visible = false;
            if (dgProducts.Columns.Contains("Category"))
                dgProducts.Columns["Category"].Visible = false;
            if (dgProducts.Columns.Contains("ProductName"))
                dgProducts.Columns["ProductName"].HeaderText = "Product";
            if (dgProducts.Columns.Contains("Quantity"))
                dgProducts.Columns["Quantity"].HeaderText = "Stock";
            if (dgProducts.Columns.Contains("Amount"))
                dgProducts.Columns["Amount"].HeaderText = "Price";
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgProducts.MultiSelect = false;
            dgProducts.ReadOnly = true;
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToDeleteRows = false;
            if (e.RowIndex < 0 || e.RowIndex >= productList.Count)
                return;
            var selectedProduct = productList[e.RowIndex];
            AddProductToOrder(selectedProduct);

        }

        private void AddProductToOrder(ProductDetailsModel product)
        {
            if (product == null) return;

            var existingOrder = orderController.GetOrders().FirstOrDefault(o => o.ItemName == product.ProductName);
            int currentQtyInCart = existingOrder != null ? existingOrder.Quantity : 0;

            if (currentQtyInCart + 1 > product.Quantity)
            {
                MessageBox.Show($"Cannot add more. '{product.ProductName}' \nstock limit reached! \nAvailable stock: {product.Quantity}",
                    "Stock Limit Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var order = new OrderProductModel
            {
                ItemName = product.ProductName,
                Quantity = 1,
                Price = product.Amount
            };

            orderController.AddOrder(order);
            RefreshReceiptGrid();
            UpdateTotalAndChange();
        }

        private void RefreshReceiptGrid()
        {
            dgViewReceipt.DataSource = null;
            dgViewReceipt.DataSource = orderController.GetOrders();
        }

        private void UpdateTotalAndChange()
        {
            decimal total = 0;
            var orders = orderController.GetOrders();
            foreach (var order in orders)
                total += order.TotalPrice;
            lblTotalReceipt.Text = " ₱" + total.ToString("N2");
            if (decimal.TryParse(txtPay.Text, out decimal payment))
            {
                decimal change = payment - total;
                lblChange.Text = " ₱" + change.ToString("N2");
            }
            else
            {
                lblChange.Text = " ₱0.00";
            }
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAndChange();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void SearchProducts()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                    productList = productController.GetAllProducts();
                else
                    productList = productController.SearchProducts(keyword);
                dgProducts.DataSource = null;
                dgProducts.DataSource = productList;
                FormatProductGrid();
                if (productList.Count == 0)
                {
                    MessageBox.Show("No products found matching '" + keyword + "'.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productList = productController.GetAllProducts();
                    dgProducts.DataSource = null;
                    dgProducts.DataSource = productList;
                    FormatProductGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgViewReceipt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string name = dgViewReceipt.SelectedRows[0].Cells["ItemName"].Value?.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                orderController.RemoveOrder(name);
                RefreshReceiptGrid();
                UpdateTotalAndChange();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            orderController.ClearAllOrders();
            RefreshReceiptGrid();
            UpdateTotalAndChange();
            txtPay.Clear();
            lblChange.Text = " ₱0.00";
            lblTotalReceipt.Text = " ₱0.00";
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            var orders = orderController.GetOrders();
            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("No items to process!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPay.Text, out decimal payment) || payment <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal total = orders.Sum(o => o.TotalPrice);
            if (payment < total)
            {
                MessageBox.Show("Paid amount is less than total!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var products = productController.GetProductsOrderedByStock();
                var lines = new List<(string ProductId, int Quantity, decimal Price)>();

                foreach (var order in orders)
                {
                    var product = products.FirstOrDefault(p => p.ProductName == order.ItemName);
                    if (product == null)
                    {
                        MessageBox.Show($"Product '{order.ItemName}' not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (product.Quantity < order.Quantity)
                    {
                        MessageBox.Show($"Not enough stock for {order.ItemName}. Available: {product.Quantity}",
                            "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lines.Add((product.ProductId, order.Quantity, order.Price));
                }

                salesController.Checkout(lines);

                PrintReceiptPreview();
                orderController.ClearAllOrders();
                RefreshReceiptGrid();
                LoadProducts();
                lblTotalReceipt.Text = "Total: ₱0.00";
                lblChange.Text = "Change: ₱0.00";
                txtPay.Clear();
                MessageBox.Show("Order processed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checkout failed. Nothing was saved.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrintReceiptPreview()
        {
            var orders = orderController.GetOrders();
            if (orders == null || orders.Count == 0) return;

            decimal total = orders.Sum(o => o.TotalPrice);
            decimal paid = decimal.TryParse(txtPay.Text, out var p) ? p : 0;
            decimal change = paid - total;

            // ---- Layout constants (1/100 inch, same unit as PaperSize) ----
            const int paperWidth = 280;
            const int margin = 10;
            float contentWidth = paperWidth - (margin * 2);

            float itemColWidth = contentWidth * 0.55f;   // item name wraps inside this width
            float qtyRight = contentWidth * 0.72f;   // right edge of Qty column
            float totalRight = contentWidth;           // right edge of Total column

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 9);
            Font tableHeaderFont = new Font("Arial", 9, FontStyle.Bold);
            Font tableFont = new Font("Arial", 9);
            int lineHeight = tableFont.Height + 4;

            StringFormat itemFormat = new StringFormat
            {
                Trimming = StringTrimming.Character,   // breaks very long words with no spaces
                FormatFlags = StringFormatFlags.NoClip
            };

            // ---- Pre-measure every item row so we know the wrapped heights ----
            // Measured in points, then converted to 1/100 inch (printer units)
            const float UnitToPoint = 72f / 100f;
            var itemHeights = new List<float>();

            using (var bmp = new Bitmap(1, 1))
            using (var g = Graphics.FromImage(bmp))
            {
                g.PageUnit = GraphicsUnit.Point;
                foreach (var order in orders)
                {
                    SizeF size = g.MeasureString(
                        order.ItemName ?? "",
                        tableFont,
                        new SizeF(itemColWidth * UnitToPoint, 10000f),
                        itemFormat);

                    float h = (size.Height / UnitToPoint) + 4;
                    itemHeights.Add(Math.Max(h, lineHeight));
                }
            }

            // ---- Dynamic paper height ----
            int receiptHeight = 220 + (int)Math.Ceiling(itemHeights.Sum());

            PrintDocument printDoc = new PrintDocument
            {
                DefaultPageSettings =
        {
            Landscape = false,
            PaperSize = new PaperSize("Receipt", paperWidth, receiptHeight),
            Margins = new Margins(margin, margin, margin, margin)
        }
            };

            printDoc.PrintPage += (s, e) =>
            {
                float left = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;
                float centerX = left + e.MarginBounds.Width / 2;

                StringFormat center = new StringFormat { Alignment = StringAlignment.Center };
                StringFormat right = new StringFormat { Alignment = StringAlignment.Far };

                e.Graphics.DrawString("Homexa", headerFont, Brushes.Black, centerX, y, center);
                y += headerFont.Height + 2;
                e.Graphics.DrawString("TIN: 123-456-789", subHeaderFont, Brushes.Black, centerX, y, center);
                y += subHeaderFont.Height + 2;
                e.Graphics.DrawString("SALES RECEIPT", subHeaderFont, Brushes.Black, centerX, y, center);
                y += subHeaderFont.Height + 4;

                e.Graphics.DrawString($"Cashier: {CurrentUser?.Username ?? "N/A"}", subHeaderFont, Brushes.Black, left, y);
                y += subHeaderFont.Height + 2;
                e.Graphics.DrawString($"Date: {DateTime.Now:MM/dd/yyyy hh:mm tt}", subHeaderFont, Brushes.Black, left, y);
                y += subHeaderFont.Height + 6;

                e.Graphics.DrawLine(Pens.Black, left, y, left + e.MarginBounds.Width, y);
                y += 4;

                // Column positions
                float colItem = left;
                float colQty = left + qtyRight;
                float colTotal = left + totalRight;

                e.Graphics.DrawString("Item", tableHeaderFont, Brushes.Black, colItem, y);
                e.Graphics.DrawString("Qty", tableHeaderFont, Brushes.Black, colQty, y, right);
                e.Graphics.DrawString("Total", tableHeaderFont, Brushes.Black, colTotal, y, right);
                y += lineHeight;
                e.Graphics.DrawLine(Pens.Black, left, y, left + e.MarginBounds.Width, y);
                y += 2;

                for (int i = 0; i < orders.Count; i++)
                {
                    var order = orders[i];
                    float rowHeight = itemHeights[i];

                    // Item name wraps inside its own rectangle
                    RectangleF itemRect = new RectangleF(colItem, y, itemColWidth, rowHeight);
                    e.Graphics.DrawString(order.ItemName, tableFont, Brushes.Black, itemRect, itemFormat);

                    // Qty and Total stay on the first line of the row
                    e.Graphics.DrawString(order.Quantity.ToString(), tableFont, Brushes.Black, colQty, y, right);
                    e.Graphics.DrawString("₱" + order.TotalPrice.ToString("N2"), tableFont, Brushes.Black, colTotal, y, right);

                    y += rowHeight;
                    e.Graphics.DrawLine(Pens.LightGray, left, y, left + e.MarginBounds.Width, y);
                }

                y += 4;
                e.Graphics.DrawLine(Pens.Black, left, y, left + e.MarginBounds.Width, y);
                y += 4;

                e.Graphics.DrawString($"TOTAL: ₱{total:N2}", tableHeaderFont, Brushes.Black, colTotal, y, right);
                y += lineHeight;
                e.Graphics.DrawString($"PAID: ₱{paid:N2}", tableHeaderFont, Brushes.Black, colTotal, y, right);
                y += lineHeight;
                e.Graphics.DrawString($"CHANGE: ₱{change:N2}", tableHeaderFont, Brushes.Black, colTotal, y, right);
                y += lineHeight + 4;

                e.Graphics.DrawString("Thank you for your purchase!", subHeaderFont, Brushes.Black, centerX, y, center);
            };

            using (PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 400,
                Height = 600
            })
            {
                preview.ShowDialog();
            }

            headerFont.Dispose();
            subHeaderFont.Dispose();
            tableHeaderFont.Dispose();
            tableFont.Dispose();
        }








    }
}

