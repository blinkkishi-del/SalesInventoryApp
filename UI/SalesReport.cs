using BusinessLogic.Controller;
using System.Data;

namespace UI
{
    public partial class SalesReport : Form
    {
        private const string AllCashiers = "All Cashiers";

        private readonly SalesController salesController = new SalesController();
        private DataTable currentSales = new DataTable();
        private bool loading = true;

        public SalesReport()
        {
            InitializeComponent();
            GridFormatHelper.ApplyModernStyle(dgList);
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = today;

            cmbCashier.Items.Add(AllCashiers);
            cmbCashier.Items.AddRange(new UserController().GetCashierUsernames().ToArray());
            cmbCashier.SelectedIndex = 0;

            loading = false;
            LoadSales();
        }

        private string SelectedCashier =>
            cmbCashier.SelectedItem is string c && c != AllCashiers ? c : null;

        private void LoadSales()
        {
            if (loading) return;
            try
            {
                currentSales = salesController.GetSalesHistory(dtpFrom.Value, dtpTo.Value, SelectedCashier, txtSearch.Text);

                dgList.DataSource = null;
                dgList.DataSource = currentSales;
                GridFormatHelper.SetHeaders(dgList,
                    ("ReceiptNo", "Receipt No"), ("SalesDate", "Date"), ("SoldBy", "Sold By"),
                    ("ProductId", "Product ID"), ("ProductName", "Product"), ("Quantity", "Qty"),
                    ("DiscountAmount", "Discount"), ("TotalPrice", "Total"));
                if (dgList.Columns.Contains("SalesDate"))
                    dgList.Columns["SalesDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                GridFormatHelper.FormatCurrencyColumns(dgList, "DiscountAmount", "TotalPrice");
                GridFormatHelper.SetColumnFillWeight(dgList, "ReceiptNo", 13);
                GridFormatHelper.SetColumnFillWeight(dgList, "SalesDate", 11);
                GridFormatHelper.SetColumnFillWeight(dgList, "SoldBy", 10);
                GridFormatHelper.SetColumnFillWeight(dgList, "ProductId", 10);
                GridFormatHelper.SetColumnFillWeight(dgList, "ProductName", 26);
                GridFormatHelper.SetColumnFillWeight(dgList, "Quantity", 6);
                GridFormatHelper.SetColumnFillWeight(dgList, "DiscountAmount", 11);
                GridFormatHelper.SetColumnFillWeight(dgList, "TotalPrice", 13);

                GridFormatHelper.HideColumns(dgList, "OrderDiscount");

                decimal orderDiscounts = currentSales.AsEnumerable()
                    .GroupBy(r => r.Field<string>("ReceiptNo"))
                    .Sum(g => g.First().Field<decimal>("OrderDiscount"));
                decimal total = currentSales.AsEnumerable().Sum(r => r.Field<decimal>("TotalPrice")) - orderDiscounts;
                decimal discount = currentSales.AsEnumerable().Sum(r => r.Field<decimal>("DiscountAmount")) + orderDiscounts;
                lblTotalValue.Text = "₱" + total.ToString("N2");
                lblDiscountValue.Text = "₱" + discount.ToString("N2");
                lblCountValue.Text = currentSales.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales history:\n" + ex.Message, "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filter_Changed(object sender, EventArgs e) => LoadSales();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadSales();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (currentSales.Rows.Count == 0)
            {
                MessageBox.Show("No sales records to print for the selected filters.",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string range = $"{dtpFrom.Value:MMMM dd, yyyy} - {dtpTo.Value:MMMM dd, yyyy}";
            string cashier = SelectedCashier ?? AllCashiers;
            GridReportPrinter.Print(dgList, "Sales History", $"{range}   |   Cashier: {cashier}",
                $"TOTAL DISCOUNT: {lblDiscountValue.Text}", $"TOTAL SALES: {lblTotalValue.Text}");
        }
    }
}
