using BusinessLogic.Controller;
using Model;
using System.Data;

namespace UI
{
    public partial class CashierDashboard : Form
    {
        private readonly SalesController salesController;
        internal UserModel CurrentUser;

        public CashierDashboard(UserModel user)
        {
            InitializeComponent();
            CurrentUser = user;
            salesController = new SalesController();
        }

        private void CashierHome_Load(object sender, EventArgs e)
        {
            lblCashierName.Text = CurrentUser?.Username ?? "—";
            lblLoginTime.Text = $"Session started: {DateTime.Now:hh:mm tt}";
            LoadData();
        }

        public void LoadData()
        {
            // KPI cards
            decimal total = salesController.GetTotalSalesToday();
            lblSalesToday.Text = $"₱{total:N2}";

            var allToday = salesController.GetSalesByDate(DateTime.Today);
            // Count distinct SalesIds for today
            var salesIds = new System.Collections.Generic.HashSet<int>();
            foreach (DataRow row in allToday.Rows)
                salesIds.Add(Convert.ToInt32(row["SalesId"]));
            lblTransactionsToday.Text = salesIds.Count.ToString();

            // Shift transaction history grid
            dgShiftHistory.DataSource = null;
            dgShiftHistory.DataSource = allToday;
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgShiftHistory.Columns.Contains("ProductId"))
                dgShiftHistory.Columns["ProductId"].Visible = false;
            if (dgShiftHistory.Columns.Contains("SalesDate"))
                dgShiftHistory.Columns["SalesDate"].HeaderText = "Date & Time";
            if (dgShiftHistory.Columns.Contains("ProductName"))
                dgShiftHistory.Columns["ProductName"].HeaderText = "Product";
            if (dgShiftHistory.Columns.Contains("Quantity"))
                dgShiftHistory.Columns["Quantity"].HeaderText = "Qty";
            if (dgShiftHistory.Columns.Contains("TotalPrice"))
                dgShiftHistory.Columns["TotalPrice"].HeaderText = "Total";

            dgShiftHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
