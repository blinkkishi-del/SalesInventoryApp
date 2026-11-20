namespace UI
{
    partial class CashierDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            outerLayout = new TableLayoutPanel();
            panelTop = new Panel();
            lblCashierName = new Label();
            lblWelcome = new Label();
            panelBody = new TableLayoutPanel();
            panelCards = new TableLayoutPanel();
            cardSales = new Panel();
            iconSalesToday = new FontAwesome.Sharp.IconPictureBox();
            lblSalesTitle = new Label();
            lblSalesToday = new Label();
            cardTransactions = new Panel();
            iconTransactionToday = new FontAwesome.Sharp.IconPictureBox();
            lblTransactionsTitle = new Label();
            lblTransactionsToday = new Label();
            panelActions = new Panel();
            lblLoginTime = new Label();
            panelGridHeader = new Panel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            lblShiftTitle = new Label();
            dgShiftHistory = new DataGridView();
            outerLayout.SuspendLayout();
            panelTop.SuspendLayout();
            panelBody.SuspendLayout();
            panelCards.SuspendLayout();
            cardSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconSalesToday).BeginInit();
            cardTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTransactionToday).BeginInit();
            panelActions.SuspendLayout();
            panelGridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgShiftHistory).BeginInit();
            SuspendLayout();
            // 
            // outerLayout
            // 
            outerLayout.ColumnCount = 1;
            outerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            outerLayout.Controls.Add(panelTop, 0, 0);
            outerLayout.Controls.Add(panelBody, 0, 1);
            outerLayout.Dock = DockStyle.Fill;
            outerLayout.Location = new Point(0, 0);
            outerLayout.Margin = new Padding(0);
            outerLayout.Name = "outerLayout";
            outerLayout.RowCount = 2;
            outerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            outerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            outerLayout.Size = new Size(1007, 550);
            outerLayout.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(26, 25, 62);
            panelTop.Controls.Add(lblCashierName);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(24, 0, 24, 0);
            panelTop.Size = new Size(1001, 84);
            panelTop.TabIndex = 0;
            // 
            // lblCashierName
            // 
            lblCashierName.AutoSize = true;
            lblCashierName.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            lblCashierName.ForeColor = Color.White;
            lblCashierName.Location = new Point(21, 37);
            lblCashierName.Name = "lblCashierName";
            lblCashierName.Size = new Size(0, 36);
            lblCashierName.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F);
            lblWelcome.ForeColor = Color.FromArgb(180, 180, 210);
            lblWelcome.Location = new Point(24, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(109, 20);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome back,";
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.FromArgb(34, 33, 74);
            panelBody.ColumnCount = 1;
            panelBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelBody.Controls.Add(panelCards, 0, 0);
            panelBody.Controls.Add(panelGridHeader, 0, 1);
            panelBody.Controls.Add(dgShiftHistory, 0, 2);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 90);
            panelBody.Margin = new Padding(0);
            panelBody.Name = "panelBody";
            panelBody.RowCount = 3;
            panelBody.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            panelBody.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            panelBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBody.Size = new Size(1007, 460);
            panelBody.TabIndex = 1;
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.FromArgb(34, 33, 74);
            panelCards.ColumnCount = 3;
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            panelCards.Controls.Add(cardSales, 0, 0);
            panelCards.Controls.Add(cardTransactions, 1, 0);
            panelCards.Controls.Add(panelActions, 2, 0);
            panelCards.Dock = DockStyle.Fill;
            panelCards.Location = new Point(0, 0);
            panelCards.Margin = new Padding(0);
            panelCards.Name = "panelCards";
            panelCards.Padding = new Padding(16, 12, 16, 8);
            panelCards.RowCount = 1;
            panelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCards.Size = new Size(1007, 118);
            panelCards.TabIndex = 0;
            // 
            // cardSales
            // 
            cardSales.BackColor = Color.FromArgb(43, 108, 196);
            cardSales.Controls.Add(iconSalesToday);
            cardSales.Controls.Add(lblSalesTitle);
            cardSales.Controls.Add(lblSalesToday);
            cardSales.Dock = DockStyle.Fill;
            cardSales.Location = new Point(16, 12);
            cardSales.Margin = new Padding(0, 0, 10, 0);
            cardSales.Name = "cardSales";
            cardSales.Padding = new Padding(16, 10, 16, 10);
            cardSales.Size = new Size(314, 98);
            cardSales.TabIndex = 0;
            // 
            // iconSalesToday
            // 
            iconSalesToday.Anchor = AnchorStyles.Right;
            iconSalesToday.BackColor = Color.Transparent;
            iconSalesToday.ForeColor = SystemColors.ButtonFace;
            iconSalesToday.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            iconSalesToday.IconColor = SystemColors.ButtonFace;
            iconSalesToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSalesToday.IconSize = 83;
            iconSalesToday.Location = new Point(192, 10);
            iconSalesToday.Name = "iconSalesToday";
            iconSalesToday.Size = new Size(89, 83);
            iconSalesToday.TabIndex = 3;
            iconSalesToday.TabStop = false;
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.AutoSize = true;
            lblSalesTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSalesTitle.ForeColor = Color.FromArgb(200, 230, 255);
            lblSalesTitle.Location = new Point(16, 10);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(115, 17);
            lblSalesTitle.TabIndex = 0;
            lblSalesTitle.Text = "Total Sales Today";
            // 
            // lblSalesToday
            // 
            lblSalesToday.AutoSize = true;
            lblSalesToday.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblSalesToday.ForeColor = Color.White;
            lblSalesToday.Location = new Point(16, 36);
            lblSalesToday.Name = "lblSalesToday";
            lblSalesToday.Size = new Size(94, 37);
            lblSalesToday.TabIndex = 1;
            lblSalesToday.Text = "₱0.00";
            // 
            // cardTransactions
            // 
            cardTransactions.BackColor = Color.FromArgb(32, 160, 110);
            cardTransactions.Controls.Add(iconTransactionToday);
            cardTransactions.Controls.Add(lblTransactionsTitle);
            cardTransactions.Controls.Add(lblTransactionsToday);
            cardTransactions.Dock = DockStyle.Fill;
            cardTransactions.Location = new Point(340, 12);
            cardTransactions.Margin = new Padding(0, 0, 10, 0);
            cardTransactions.Name = "cardTransactions";
            cardTransactions.Padding = new Padding(16, 10, 16, 10);
            cardTransactions.Size = new Size(314, 98);
            cardTransactions.TabIndex = 1;
            // 
            // iconTransactionToday
            // 
            iconTransactionToday.Anchor = AnchorStyles.Right;
            iconTransactionToday.BackColor = Color.Transparent;
            iconTransactionToday.ForeColor = SystemColors.ButtonFace;
            iconTransactionToday.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            iconTransactionToday.IconColor = SystemColors.ButtonFace;
            iconTransactionToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTransactionToday.IconSize = 83;
            iconTransactionToday.Location = new Point(206, 10);
            iconTransactionToday.Name = "iconTransactionToday";
            iconTransactionToday.Size = new Size(89, 83);
            iconTransactionToday.TabIndex = 4;
            iconTransactionToday.TabStop = false;
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.AutoSize = true;
            lblTransactionsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTransactionsTitle.ForeColor = Color.FromArgb(200, 255, 230);
            lblTransactionsTitle.Location = new Point(16, 10);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(126, 17);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "Transactions Today";
            // 
            // lblTransactionsToday
            // 
            lblTransactionsToday.AutoSize = true;
            lblTransactionsToday.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblTransactionsToday.ForeColor = Color.White;
            lblTransactionsToday.Location = new Point(16, 36);
            lblTransactionsToday.Name = "lblTransactionsToday";
            lblTransactionsToday.Size = new Size(33, 37);
            lblTransactionsToday.TabIndex = 1;
            lblTransactionsToday.Text = "0";
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.FromArgb(31, 30, 68);
            panelActions.Controls.Add(lblLoginTime);
            panelActions.Dock = DockStyle.Fill;
            panelActions.Location = new Point(664, 12);
            panelActions.Margin = new Padding(0);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(327, 98);
            panelActions.TabIndex = 2;
            // 
            // lblLoginTime
            // 
            lblLoginTime.Anchor = AnchorStyles.Left;
            lblLoginTime.AutoSize = true;
            lblLoginTime.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTime.ForeColor = Color.FromArgb(172, 126, 241);
            lblLoginTime.Location = new Point(37, 36);
            lblLoginTime.Name = "lblLoginTime";
            lblLoginTime.Size = new Size(83, 30);
            lblLoginTime.TabIndex = 0;
            lblLoginTime.Text = "Session";
            // 
            // panelGridHeader
            // 
            panelGridHeader.BackColor = Color.FromArgb(31, 30, 68);
            panelGridHeader.Controls.Add(btnRefresh);
            panelGridHeader.Controls.Add(lblShiftTitle);
            panelGridHeader.Dock = DockStyle.Fill;
            panelGridHeader.Location = new Point(3, 121);
            panelGridHeader.Name = "panelGridHeader";
            panelGridHeader.Padding = new Padding(16, 0, 16, 0);
            panelGridHeader.Size = new Size(1001, 36);
            panelGridHeader.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(172, 126, 241);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 15;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(1681, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(4, 0, 8, 0);
            btnRefresh.Size = new Size(104, 0);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblShiftTitle
            // 
            lblShiftTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblShiftTitle.AutoSize = true;
            lblShiftTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblShiftTitle.ForeColor = Color.Gainsboro;
            lblShiftTitle.Location = new Point(16, 10);
            lblShiftTitle.Name = "lblShiftTitle";
            lblShiftTitle.Size = new Size(151, 19);
            lblShiftTitle.TabIndex = 1;
            lblShiftTitle.Text = "Today's Sales History";
            // 
            // dgShiftHistory
            // 
            dgShiftHistory.AllowUserToAddRows = false;
            dgShiftHistory.AllowUserToDeleteRows = false;
            dgShiftHistory.AllowUserToResizeColumns = false;
            dgShiftHistory.AllowUserToResizeRows = false;
            dgShiftHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgShiftHistory.BackgroundColor = Color.FromArgb(34, 33, 74);
            dgShiftHistory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgShiftHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgShiftHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgShiftHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgShiftHistory.Dock = DockStyle.Fill;
            dgShiftHistory.GridColor = Color.FromArgb(55, 54, 105);
            dgShiftHistory.Location = new Point(16, 160);
            dgShiftHistory.Margin = new Padding(16, 0, 16, 16);
            dgShiftHistory.MultiSelect = false;
            dgShiftHistory.Name = "dgShiftHistory";
            dgShiftHistory.ReadOnly = true;
            dgShiftHistory.RowHeadersVisible = false;
            dgShiftHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgShiftHistory.Size = new Size(975, 284);
            dgShiftHistory.TabIndex = 10;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 550);
            Controls.Add(outerLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierDashboard";
            Text = "Dashboard";
            Load += CashierHome_Load;
            outerLayout.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBody.ResumeLayout(false);
            panelCards.ResumeLayout(false);
            cardSales.ResumeLayout(false);
            cardSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconSalesToday).EndInit();
            cardTransactions.ResumeLayout(false);
            cardTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTransactionToday).EndInit();
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            panelGridHeader.ResumeLayout(false);
            panelGridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgShiftHistory).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel outerLayout;
        private Panel panelTop;
        private Label lblWelcome;
        private Label lblCashierName;
        private Label lblLoginTime;
        private TableLayoutPanel panelBody;
        private TableLayoutPanel panelCards;
        private Panel cardSales;
        private Label lblSalesTitle;
        private Label lblSalesToday;
        private Panel cardTransactions;
        private Label lblTransactionsTitle;
        private Label lblTransactionsToday;
        private Panel panelActions;
        private Panel panelGridHeader;
        private Label lblShiftTitle;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private DataGridView dgShiftHistory;
        private FontAwesome.Sharp.IconPictureBox iconSalesToday;
        private FontAwesome.Sharp.IconPictureBox iconTransactionToday;
    }
}
