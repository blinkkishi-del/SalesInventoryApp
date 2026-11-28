using BusinessLogic.Controller;
using Model;
using System.Drawing.Printing;

namespace UI
{
    public partial class PointofSales : Form
    {
        private OrderProductController orderController = null!;
        private readonly ProductController productController;
        private readonly SalesController salesController;
        private List<ProductDetailsModel> productList;
        internal UserModel CurrentUser;

        private decimal orderDiscountPercent;
        private decimal cashPaid;

        private decimal OrderDiscountOf(decimal grandTotal) => Math.Round(grandTotal * orderDiscountPercent / 100m, 2);

        public PointofSales()
        {
            InitializeComponent();
            productController = new ProductController();
            salesController = new SalesController();
            txtSearch.KeyDown += txtSearch_KeyDown;
            datetpDate.Enabled = false;
        }

        private void POS_Load(object sender, EventArgs e)
        {
            orderController = new OrderProductController(CurrentUser?.Username);
            ShowNextReceiptNo();
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

        private void ShowNextReceiptNo()
        {
            lblReceiptNo.Text = "Invoice No: " + salesController.GetNextReceiptNo();
        }

        private void LoadProducts()
        {
            try
            {
                productList = productController.GetProductsOrderedByStock().Where(p => p.Quantity > 0).ToList();
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

            GridFormatHelper.SetColumnFillWeight(dgProducts, "ProductName", 30);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "Model", 16);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "Brand", 20);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "Quantity", 12);
            GridFormatHelper.SetColumnFillWeight(dgProducts, "Amount", 22);

            GridFormatHelper.FormatCurrencyColumns(dgProducts, "Amount");
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
            int qty = (int)nudQty.Value;

            if (currentQtyInCart + qty > product.Quantity)
            {
                MessageBox.Show($"Cannot add more. '{product.ProductName}' \nstock limit reached! \nAvailable stock: {product.Quantity}",
                    "Stock Limit Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var order = new OrderProductModel
            {
                ItemName = product.ProductName,
                Quantity = qty,
                Price = product.Amount
            };

            orderController.AddOrder(order);
            RefreshReceiptGrid();
            UpdateTotalAndChange();
            nudQty.Value = 1;
        }

        private void dgProducts_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            if (dgProducts.CurrentRow?.DataBoundItem is ProductDetailsModel product)
                AddProductToOrder(product);
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            SearchProducts();
            dgProducts.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1: txtSearch.Focus(); txtSearch.SelectAll(); return true;
                case Keys.F2: nudQty.Focus(); nudQty.Select(0, nudQty.Text.Length); return true;
                case Keys.F3: btnDiscount.PerformClick(); return true;
                case Keys.F4: btnDelete.PerformClick(); return true;
                case Keys.F5:
                    if (MessageBox.Show("Void the whole cart?", "Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        btnCancel.PerformClick();
                    return true;
                case Keys.F8: btnPay.PerformClick(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RefreshReceiptGrid()
        {
            dgViewReceipt.DataSource = null;
            dgViewReceipt.DataSource = orderController.GetOrders();
            GridFormatHelper.FormatCurrencyColumns(dgViewReceipt, "Price", "DiscountAmount", "TotalPrice");
            GridFormatHelper.HideColumns(dgViewReceipt, "DiscountPercent");
            GridFormatHelper.SetHeaders(dgViewReceipt, ("ItemName", "Item"), ("Quantity", "Qty"),
                ("DiscountAmount", "Discount"), ("TotalPrice", "Total"));

            GridFormatHelper.SetColumnFillWeight(dgViewReceipt, "ItemName", 34);
            GridFormatHelper.SetColumnFillWeight(dgViewReceipt, "Quantity", 10);
            GridFormatHelper.SetColumnFillWeight(dgViewReceipt, "Price", 18);
            GridFormatHelper.SetColumnFillWeight(dgViewReceipt, "DiscountAmount", 18);
            GridFormatHelper.SetColumnFillWeight(dgViewReceipt, "TotalPrice", 20);

            if (dgViewReceipt.Columns.Contains("ItemName"))
            {
                var item = dgViewReceipt.Columns["ItemName"].DefaultCellStyle;
                item.Alignment = DataGridViewContentAlignment.MiddleLeft;
                item.WrapMode = DataGridViewTriState.True;
            }
            dgViewReceipt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void UpdateTotalAndChange()
        {
            var orders = orderController.GetOrders();
            if (orders.Count == 0) orderDiscountPercent = 0;
            decimal grandTotal = orders.Sum(o => o.TotalPrice);
            decimal total = grandTotal - OrderDiscountOf(grandTotal);
            lblTotalReceipt.Text = " ₱" + total.ToString("N2")
                + (orderDiscountPercent > 0 ? $"  (-{orderDiscountPercent:0.##}% order)" : "");
            lblPay.Text = " ₱" + cashPaid.ToString("N2");
            lblChange.Text = " ₱" + (cashPaid > 0 ? cashPaid - total : 0).ToString("N2");
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
                productList = productList.Where(p => p.Quantity > 0).ToList();
                dgProducts.DataSource = null;
                dgProducts.DataSource = productList;
                FormatProductGrid();
                if (productList.Count == 0)
                {
                    MessageBox.Show("No products found matching '" + keyword + "'.", "Search Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productList = productController.GetAllProducts().Where(p => p.Quantity > 0).ToList();
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
            orderDiscountPercent = 0;
            orderController.ClearAllOrders();
            RefreshReceiptGrid();
            cashPaid = 0;
            UpdateTotalAndChange();
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            var orders = orderController.GetOrders();
            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("Add items to the receipt before applying a discount.", "Discount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = dgViewReceipt.CurrentRow?.DataBoundItem as OrderProductModel;
            using var dialog = new DiscountForm(selected, orders, orderDiscountPercent);
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                if (dialog.WholeOrder)
                    orderDiscountPercent = dialog.DiscountPercent;
                else
                    orderController.SetDiscount(selected!.ItemName, dialog.DiscountPercent);
                RefreshReceiptGrid();
                UpdateTotalAndChange();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            decimal grandTotal = orders.Sum(o => o.TotalPrice);
            decimal total = grandTotal - OrderDiscountOf(grandTotal);

            using (var settle = new SettleForm(total, cashPaid))
            {
                if (settle.ShowDialog(this) != DialogResult.OK) return;
                cashPaid = settle.Cash;
            }
            UpdateTotalAndChange();
            try
            {
                var products = productController.GetProductsOrderedByStock();
                var lines = new List<(string ProductId, int Quantity, decimal Price, decimal DiscountAmount)>();

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
                    lines.Add((product.ProductId, order.Quantity, order.Price, order.DiscountAmount));
                }

                string receiptNo = salesController.Checkout(lines, CurrentUser?.Username, orderDiscountPercent);
                lblReceiptNo.Text = "Invoice No: " + receiptNo;

                PrintReceiptPreview(receiptNo);
                orderController.ClearAllOrders();
                orderDiscountPercent = 0;
                RefreshReceiptGrid();
                LoadProducts();
                ShowNextReceiptNo();
                string paidText = lblPay.Text, changeText = lblChange.Text;
                cashPaid = 0;
                UpdateTotalAndChange();
                lblPay.Text = paidText;
                lblChange.Text = changeText;
                MessageBox.Show("Order processed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checkout failed. Nothing was saved.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintReceiptPreview(string receiptNo)
        {
            var orders = orderController.GetOrders();
            if (orders == null || orders.Count == 0) return;

            decimal grandTotal = orders.Sum(o => o.TotalPrice);
            decimal totalDiscount = orders.Sum(o => o.DiscountAmount);
            decimal subtotal = grandTotal + totalDiscount;
            decimal orderDiscount = OrderDiscountOf(grandTotal);
            decimal total = grandTotal - orderDiscount;
            decimal paid = cashPaid;
            decimal change = paid - total;

            const int paperWidth = 280;
            const int margin = 10;
            float contentWidth = paperWidth - (margin * 2);

            float itemColWidth = contentWidth * 0.55f;
            float qtyRight = contentWidth * 0.72f;
            float totalRight = contentWidth;

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 9);
            Font tableHeaderFont = new Font("Arial", 9, FontStyle.Bold);
            Font tableFont = new Font("Arial", 9);
            int lineHeight = tableFont.Height + 4;

            StringFormat itemFormat = new StringFormat
            {
                Trimming = StringTrimming.Character,
                FormatFlags = StringFormatFlags.NoClip
            };

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

                    float h = Math.Max((size.Height / UnitToPoint) + 4, lineHeight);
                    if (order.DiscountAmount > 0) h += lineHeight;
                    itemHeights.Add(h);
                }
            }

            int receiptHeight = 220 + (int)Math.Ceiling(itemHeights.Sum())
                                + (totalDiscount > 0 || orderDiscount > 0 ? lineHeight * 2 : 0)
                                + (orderDiscount > 0 ? lineHeight : 0);

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
                e.Graphics.DrawString($"Invoice No: {receiptNo}", subHeaderFont, Brushes.Black, centerX, y, center);
                y += subHeaderFont.Height + 2;
                e.Graphics.DrawString("INVOICE RECEIPT", subHeaderFont, Brushes.Black, centerX, y, center);
                y += subHeaderFont.Height + 4;

                e.Graphics.DrawString($"Cashier: {CurrentUser?.Username ?? "N/A"}", subHeaderFont, Brushes.Black, left, y);
                y += subHeaderFont.Height + 2;
                e.Graphics.DrawString($"Date: {DateTime.Now:MM/dd/yyyy hh:mm tt}", subHeaderFont, Brushes.Black, left, y);
                y += subHeaderFont.Height + 6;

                e.Graphics.DrawLine(Pens.Black, left, y, left + e.MarginBounds.Width, y);
                y += 4;

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

                    RectangleF itemRect = new RectangleF(colItem, y, itemColWidth, rowHeight);
                    e.Graphics.DrawString(order.ItemName, tableFont, Brushes.Black, itemRect, itemFormat);

                    e.Graphics.DrawString(order.Quantity.ToString(), tableFont, Brushes.Black, colQty, y, right);
                    e.Graphics.DrawString("₱" + order.TotalPrice.ToString("N2"), tableFont, Brushes.Black, colTotal, y, right);

                    if (order.DiscountAmount > 0)
                    {
                        float discY = y + rowHeight - lineHeight;
                        e.Graphics.DrawString($"  Less {order.DiscountPercent:0.##}% discount", tableFont, Brushes.Black, colItem, discY);
                        e.Graphics.DrawString("-₱" + order.DiscountAmount.ToString("N2"), tableFont, Brushes.Black, colTotal, discY, right);
                    }

                    y += rowHeight;
                    e.Graphics.DrawLine(Pens.LightGray, left, y, left + e.MarginBounds.Width, y);
                }

                y += 4;
                e.Graphics.DrawLine(Pens.Black, left, y, left + e.MarginBounds.Width, y);
                y += 4;

                if (totalDiscount > 0 || orderDiscount > 0)
                {
                    e.Graphics.DrawString($"SUBTOTAL: ₱{subtotal:N2}", tableFont, Brushes.Black, colTotal, y, right);
                    y += lineHeight;
                    if (totalDiscount > 0)
                    {
                        e.Graphics.DrawString($"ITEM DISCOUNT: -₱{totalDiscount:N2}", tableFont, Brushes.Black, colTotal, y, right);
                        y += lineHeight;
                    }
                    if (orderDiscount > 0)
                    {
                        e.Graphics.DrawString($"ORDER DISCOUNT ({orderDiscountPercent:0.##}%): -₱{orderDiscount:N2}", tableFont, Brushes.Black, colTotal, y, right);
                        y += lineHeight;
                    }
                }
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

