namespace UI
{
    public partial class SettleForm : Form
    {
        private static readonly Color Accent = Color.FromArgb(124, 58, 237);
        private readonly decimal total;

        public decimal Cash { get; private set; }

        public SettleForm(decimal total, decimal initialCash)
        {
            InitializeComponent();
            this.total = total;
            lblTotalValue.Text = "₱" + total.ToString("N2");

            AddQuickButton("EXACT", () => SetCash(total));
            foreach (int bill in new[] { 100, 500, 1000 })
                AddQuickButton($"+{bill:N0}", () => SetCash(CurrentCash() + bill));
            AddQuickButton("CLEAR", () => txtCash.Clear());

            string[] keys = { "7", "8", "9", "4", "5", "6", "1", "2", "3", "00", "0", "⌫" };
            for (int i = 0; i < keys.Length; i++)
            {
                string key = keys[i];
                var button = MakeButton(key, Color.White, Accent);
                button.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
                button.Dock = DockStyle.Fill;
                button.Margin = new Padding(3);
                button.Click += (s, e) => PressKey(key);
                tableKeypad.Controls.Add(button, i % 3, i / 3);
            }

            if (initialCash > 0) SetCash(initialCash);
            UpdateChange();
            Shown += (s, e) => { txtCash.Focus(); txtCash.SelectAll(); };
        }

        private void AddQuickButton(string text, Action onClick)
        {
            var button = MakeButton(text, Accent, Color.White);
            button.Size = new Size(text == "EXACT" ? 80 : 64, 34);
            button.Margin = new Padding(3, 3, 3, 3);
            button.Click += (s, e) => { onClick(); txtCash.Focus(); };
            flowQuick.Controls.Add(button);
        }

        private static Button MakeButton(string text, Color back, Color fore)
        {
            var button = new Button
            {
                Text = text,
                BackColor = back,
                ForeColor = fore,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                TabStop = false,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderColor = Accent;
            return button;
        }

        private void PressKey(string key)
        {
            if (key == "⌫")
            {
                if (txtCash.Text.Length > 0) txtCash.Text = txtCash.Text[..^1];
            }
            else if (txtCash.Text.Length + key.Length <= txtCash.MaxLength)
            {
                txtCash.Text += key;
            }
            txtCash.SelectionStart = txtCash.Text.Length;
            txtCash.Focus();
        }

        private decimal CurrentCash() => decimal.TryParse(txtCash.Text, out decimal cash) ? cash : 0;

        private void SetCash(decimal cash)
        {
            txtCash.Text = cash.ToString("0.##");
            txtCash.SelectionStart = txtCash.Text.Length;
        }

        private void txtCash_TextChanged(object sender, EventArgs e) => UpdateChange();

        private void UpdateChange()
        {
            bool valid = decimal.TryParse(txtCash.Text, out decimal cash) && cash >= total;
            Cash = valid ? cash : 0;
            lblChangeValue.Text = valid ? "₱" + (cash - total).ToString("N2") : "—";
            btnConfirm.Enabled = valid;
            btnConfirm.BackColor = valid ? Color.FromArgb(46, 204, 113) : Color.Silver;
        }
    }
}
    