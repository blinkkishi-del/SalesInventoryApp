using BusinessLogic.Controller;
using System.Data;

namespace UI
{
    public partial class POSRecord : Form
    {
        public POSRecord()
        {
            InitializeComponent();

            var sales = new SalesController();
            var stock = new StockController();
            var stockIn = new StockInController();

            reportTopSelling.ReportTitle = "Top Selling Products";
            reportTopSelling.LoadData = sales.GetTopSelling;
            reportTopSelling.FormatGrid = grid =>
            {
                GridFormatHelper.SetHeaders(grid, ("Rank", "#"), ("ProductId", "Product ID"), ("ProductName", "Product"),
                    ("Quantity", "Qty Sold"), ("TotalPrice", "Total Sales"));
                GridFormatHelper.FormatCurrencyColumns(grid, "TotalPrice");
                GridFormatHelper.SetColumnFillWeights(grid, ("Rank", 6), ("ProductId", 12), ("ProductName", 34),
                    ("Model", 14), ("Brand", 12), ("Quantity", 9), ("TotalPrice", 13));
            };
            reportTopSelling.Summary = dt => new[]
            {
                $"Units: {Sum<int>(dt, "Quantity"):N0}",
                $"Total Sales: ₱{Sum<decimal>(dt, "TotalPrice"):N2} (before order discounts)"
            };

            reportSoldItems.ReportTitle = "Sold Items";
            reportSoldItems.LoadData = sales.GetSoldItemsSummary;
            reportSoldItems.FormatGrid = grid =>
            {
                GridFormatHelper.SetHeaders(grid, ("ProductId", "Product ID"), ("ProductName", "Product"),
                    ("Quantity", "Qty Sold"), ("DiscountAmount", "Discount"), ("TotalPrice", "Total"));
                GridFormatHelper.FormatCurrencyColumns(grid, "DiscountAmount", "TotalPrice");
                GridFormatHelper.SetColumnFillWeights(grid, ("ProductId", 13), ("ProductName", 37), ("Model", 14),
                    ("Quantity", 10), ("DiscountAmount", 12), ("TotalPrice", 14));
            };
            reportSoldItems.Summary = dt =>
            {
                decimal itemSales = Sum<decimal>(dt, "TotalPrice");
                decimal orderDiscounts = sales.GetOrderDiscountTotal(reportSoldItems.From, reportSoldItems.To);
                return new[]
                {
                    $"Units: {Sum<int>(dt, "Quantity"):N0}",
                    $"Item Discounts: ₱{Sum<decimal>(dt, "DiscountAmount"):N2}",
                    $"Order Discounts: ₱{orderDiscounts:N2}",
                    $"Net Sales: ₱{itemSales - orderDiscounts:N2}"
                };
            };

            reportCritical.ReportTitle = "Critical Stocks";
            reportCritical.UseDateRange = false;
            reportCritical.LoadData = (_, _) => stock.GetCriticalStocks();
            reportCritical.FormatGrid = FormatStockGrid;
            reportCritical.Summary = dt => new[]
            {
                $"Critical items (stock ≤ {StockController.LowStockThreshold}): {dt.Rows.Count:N0}"
            };

            reportInventory.ReportTitle = "Inventory List";
            reportInventory.UseDateRange = false;
            reportInventory.LoadData = (_, _) => stock.GetInventoryList();
            reportInventory.FormatGrid = FormatStockGrid;
            reportInventory.Summary = dt => new[]
            {
                $"Products: {dt.Rows.Count:N0}",
                $"Units in stock: {Sum<int>(dt, "Quantity"):N0}",
                $"Stock value: ₱{dt.AsEnumerable().Sum(r => Dec(r, "Quantity") * Dec(r, "Amount")):N2}"
            };

            reportStockIn.ReportTitle = "Stock-In History";
            reportStockIn.LoadData = stockIn.GetHistory;
            reportStockIn.FormatGrid = grid =>
            {
                GridFormatHelper.SetHeaders(grid, ("ReferenceNo", "Reference No"), ("StockInDate", "Date"),
                    ("ProductId", "Product ID"), ("ProductName", "Product"), ("Quantity", "Qty"),
                    ("SupplierName", "Supplier"), ("StockInBy", "Stocked In By"));
                GridFormatHelper.FormatDateColumns(grid, "StockInDate");
                GridFormatHelper.SetColumnFillWeights(grid, ("ReferenceNo", 15), ("StockInDate", 15), ("ProductId", 10),
                    ("ProductName", 22), ("Model", 10), ("Quantity", 6), ("SupplierName", 14), ("StockInBy", 8));
            };
            reportStockIn.Summary = dt => new[]
            {
                $"Entries: {dt.Rows.Count:N0}",
                $"Units received: {Sum<int>(dt, "Quantity"):N0}"
            };
        }

        private static void FormatStockGrid(DataGridView grid)
        {
            GridFormatHelper.SetHeaders(grid, ("ProductId", "Product ID"), ("ProductName", "Product"),
                ("Quantity", "Stock"), ("Amount", "Price"), ("StockHealth", "Stock Health"));
            GridFormatHelper.FormatCurrencyColumns(grid, "Amount");
            GridFormatHelper.SetColumnFillWeights(grid, ("ProductId", 10), ("ProductName", 24), ("Model", 11),
                ("Brand", 11), ("Category", 12), ("Supplier", 15), ("Quantity", 6), ("Amount", 10), ("StockHealth", 10));

            grid.CellFormatting -= LowStockRed;
            grid.CellFormatting += LowStockRed;
        }

        private static void LowStockRed(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender!;
            if (grid.Columns[e.ColumnIndex].Name == "StockHealth" && e.Value?.ToString() == "Low Stock")
            {
                e.CellStyle!.ForeColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.Red;
            }
        }

        private static T Sum<T>(DataTable dt, string column) where T : struct =>
            (T)Convert.ChangeType(dt.AsEnumerable().Sum(r => Dec(r, column)), typeof(T));

        private static decimal Dec(DataRow r, string column) =>
            r[column] is DBNull ? 0m : Convert.ToDecimal(r[column]);
    }
}
