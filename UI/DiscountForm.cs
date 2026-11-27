using Model;

namespace UI
{
    public partial class DiscountForm : Form
    {
        private static readonly Color Accent = Color.FromArgb(124, 58, 237);

        private readonly OrderProductModel? selected;
        private readonly List<OrderProductModel> orders;
        private readonly decimal currentOrderPercent;

        public decimal DiscountPercent => nudPercent.Value;
        public bool WholeOrder { get; private set; }

        public DiscountForm(OrderProductModel? selected, List<OrderProductModel> orders, decimal currentOrderPercent)
        {
            InitializeComponent();
            this.selected = selected;
            this.orders = orders;
            this.currentOrderPercent = currentOrderPercent;

            btnScopeItem.Enabled = selected != null;
            SetScope(wholeOrder: selected == null);
        }

        private void SetScope(bool wholeOrder)
        {
            WholeOrder = wholeOrder;
            StyleScopeButton(btnScopeItem, !wholeOrder);
            StyleScopeButton(btnScopeOrder, wholeOrder);

            if (wholeOrder)
            {
                lblItem.Text = "Applies to";
                lblItemValue.Text = $"Grand total of {orders.Count} item(s)";
                lblAmount.Text = "Grand total";
                lblNewTotal.Text = "Amount to pay";
                nudPercent.Value = currentOrderPercent;
            }
            else
            {
                lblItem.Text = "Item";
                lblItemValue.Text = $"{selected!.ItemName}  ×{selected.Quantity}";
                lblAmount.Text = "Line amount";
                lblNewTotal.Text = "New line total";
                nudPercent.Value = selected.DiscountPercent;
            }
            UpdatePreview();
        }

        private static void StyleScopeButton(Button button, bool active)
        {
            button.BackColor = active ? Accent : Color.White;
            button.ForeColor = active ? Color.White : (button.Enabled ? Accent : Color.Silver);
        }

        private void UpdatePreview()
        {
            decimal amount = WholeOrder ? orders.Sum(o => o.TotalPrice) : selected!.Quantity * selected.Price;
            decimal discount = Math.Round(amount * nudPercent.Value / 100m, 2);

            lblAmountValue.Text = "₱" + amount.ToString("N2");
            lblDiscountValue.Text = "-₱" + discount.ToString("N2");
            lblNewTotalValue.Text = "₱" + (amount - discount).ToString("N2");
        }

        private void nudPercent_ValueChanged(object sender, EventArgs e) => UpdatePreview();

        private void btnScopeItem_Click(object sender, EventArgs e) => SetScope(wholeOrder: false);
        private void btnScopeOrder_Click(object sender, EventArgs e) => SetScope(wholeOrder: true);

        private void btn5_Click(object sender, EventArgs e) => nudPercent.Value = 5;
        private void btn10_Click(object sender, EventArgs e) => nudPercent.Value = 10;
        private void btnSenior_Click(object sender, EventArgs e) => nudPercent.Value = 20;
        private void btnNone_Click(object sender, EventArgs e) => nudPercent.Value = 0;
    }
}
