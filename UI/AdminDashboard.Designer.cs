namespace UI
{
    partial class AdminDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            rootLayout = new TableLayoutPanel();
            panelCards = new TableLayoutPanel();
            panel1 = new Panel();
            iconTotalInventory = new FontAwesome.Sharp.IconPictureBox();
            lblTotalInventory = new Label();
            label1 = new Label();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblLowStock = new Label();
            label2 = new Label();
            panel4 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalSalesToday = new Label();
            label3 = new Label();
            panelLookup = new Panel();
            lblLookupTitle = new Label();
            dtpSalesLookup = new DateTimePicker();
            btnLookupSales = new FontAwesome.Sharp.IconButton();
            lblSalesForDate = new Label();
            panelMiddle = new TableLayoutPanel();
            panelChartWrap = new Panel();
            panelChart = new Panel();
            lblChartTitle = new Label();
            panelTopSellersWrap = new Panel();
            dgridTopSellers = new DataGridView();
            lblTopSellersTitle = new Label();
            panelSectionHeader = new Panel();
            lblLowStacks = new Label();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnPrintLowStock = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label4 = new Label();
            dgridLowStock = new DataGridView();
            rootLayout.SuspendLayout();
            panelCards.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalInventory).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panelLookup.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelChartWrap.SuspendLayout();
            panelTopSellersWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridTopSellers).BeginInit();
            panelSectionHeader.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLowStock).BeginInit();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.BackColor = Color.FromArgb(34, 33, 74);
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootLayout.Controls.Add(panelCards, 0, 0);
            rootLayout.Controls.Add(panelMiddle, 0, 1);
            rootLayout.Controls.Add(panelSectionHeader, 0, 2);
            rootLayout.Controls.Add(dgridLowStock, 0, 3);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Margin = new Padding(0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16, 12, 16, 12);
            rootLayout.RowCount = 4;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 118F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            rootLayout.Size = new Size(1007, 622);
            rootLayout.TabIndex = 0;
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.Transparent;
            panelCards.ColumnCount = 4;
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelCards.Controls.Add(panel1, 0, 0);
            panelCards.Controls.Add(panel2, 1, 0);
            panelCards.Controls.Add(panel4, 2, 0);
            panelCards.Controls.Add(panelLookup, 3, 0);
            panelCards.Dock = DockStyle.Fill;
            panelCards.Location = new Point(16, 12);
            panelCards.Margin = new Padding(0, 0, 0, 10);
            panelCards.Name = "panelCards";
            panelCards.RowCount = 1;
            panelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCards.Size = new Size(975, 108);
            panelCards.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(iconTotalInventory);
            panel1.Controls.Add(lblTotalInventory);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 10, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12, 10, 10, 10);
            panel1.Size = new Size(233, 108);
            panel1.TabIndex = 0;
            // 
            // iconTotalInventory
            // 
            iconTotalInventory.Anchor = AnchorStyles.Right;
            iconTotalInventory.BackColor = Color.Transparent;
            iconTotalInventory.ForeColor = SystemColors.ControlText;
            iconTotalInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconTotalInventory.IconColor = SystemColors.ControlText;
            iconTotalInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTotalInventory.IconSize = 60;
            iconTotalInventory.Location = new Point(160, 27);
            iconTotalInventory.Name = "iconTotalInventory";
            iconTotalInventory.Size = new Size(60, 60);
            iconTotalInventory.TabIndex = 0;
            iconTotalInventory.TabStop = false;
            // 
            // lblTotalInventory
            // 
            lblTotalInventory.AutoSize = true;
            lblTotalInventory.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblTotalInventory.Location = new Point(12, 36);
            lblTotalInventory.Name = "lblTotalInventory";
            lblTotalInventory.Size = new Size(28, 32);
            lblTotalInventory.TabIndex = 1;
            lblTotalInventory.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(111, 16);
            label1.TabIndex = 2;
            label1.Text = "Total Inventory";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(lblLowStock);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(243, 0);
            panel2.Margin = new Padding(0, 0, 10, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12, 10, 10, 10);
            panel2.Size = new Size(233, 108);
            panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Warning;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 60;
            iconPictureBox1.Location = new Point(160, 25);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(60, 60);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.White;
            lblLowStock.Location = new Point(12, 36);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(28, 32);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 2;
            label2.Text = "Low Stocks";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(iconPictureBox3);
            panel4.Controls.Add(lblTotalSalesToday);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(486, 0);
            panel4.Margin = new Padding(0, 0, 10, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(12, 10, 10, 10);
            panel4.Size = new Size(233, 108);
            panel4.TabIndex = 2;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Right;
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconPictureBox3.IconColor = Color.White;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 60;
            iconPictureBox3.Location = new Point(160, 25);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(60, 60);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // lblTotalSalesToday
            // 
            lblTotalSalesToday.AutoSize = true;
            lblTotalSalesToday.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            lblTotalSalesToday.ForeColor = Color.White;
            lblTotalSalesToday.Location = new Point(12, 38);
            lblTotalSalesToday.Name = "lblTotalSalesToday";
            lblTotalSalesToday.Size = new Size(76, 30);
            lblTotalSalesToday.TabIndex = 1;
            lblTotalSalesToday.Text = "₱0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 10);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 2;
            label3.Text = "Today's Sales";
            // 
            // panelLookup
            // 
            panelLookup.BackColor = Color.FromArgb(43, 42, 90);
            panelLookup.Controls.Add(lblLookupTitle);
            panelLookup.Controls.Add(dtpSalesLookup);
            panelLookup.Controls.Add(btnLookupSales);
            panelLookup.Controls.Add(lblSalesForDate);
            panelLookup.Dock = DockStyle.Fill;
            panelLookup.Location = new Point(729, 0);
            panelLookup.Margin = new Padding(0);
            panelLookup.Name = "panelLookup";
            panelLookup.Padding = new Padding(12, 8, 12, 8);
            panelLookup.Size = new Size(246, 108);
            panelLookup.TabIndex = 3;
            // 
            // lblLookupTitle
            // 
            lblLookupTitle.AutoSize = true;
            lblLookupTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLookupTitle.ForeColor = Color.Silver;
            lblLookupTitle.Location = new Point(12, 8);
            lblLookupTitle.Name = "lblLookupTitle";
            lblLookupTitle.Size = new Size(81, 15);
            lblLookupTitle.TabIndex = 0;
            lblLookupTitle.Text = "Sales by Date";
            // 
            // dtpSalesLookup
            // 
            dtpSalesLookup.Font = new Font("Segoe UI", 9F);
            dtpSalesLookup.Format = DateTimePickerFormat.Short;
            dtpSalesLookup.Location = new Point(12, 28);
            dtpSalesLookup.Name = "dtpSalesLookup";
            dtpSalesLookup.Size = new Size(126, 23);
            dtpSalesLookup.TabIndex = 1;
            // 
            // btnLookupSales
            // 
            btnLookupSales.BackColor = Color.FromArgb(172, 126, 241);
            btnLookupSales.FlatAppearance.BorderSize = 0;
            btnLookupSales.FlatStyle = FlatStyle.Flat;
            btnLookupSales.ForeColor = Color.White;
            btnLookupSales.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnLookupSales.IconColor = Color.White;
            btnLookupSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLookupSales.IconSize = 14;
            btnLookupSales.Location = new Point(144, 27);
            btnLookupSales.Name = "btnLookupSales";
            btnLookupSales.Size = new Size(54, 24);
            btnLookupSales.TabIndex = 2;
            btnLookupSales.Text = "Go";
            btnLookupSales.TextAlign = ContentAlignment.MiddleRight;
            btnLookupSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLookupSales.UseVisualStyleBackColor = false;
            btnLookupSales.Click += btnLookupSales_Click;
            // 
            // lblSalesForDate
            // 
            lblSalesForDate.AutoSize = true;
            lblSalesForDate.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblSalesForDate.ForeColor = Color.FromArgb(172, 126, 241);
            lblSalesForDate.Location = new Point(12, 60);
            lblSalesForDate.Name = "lblSalesForDate";
            lblSalesForDate.Size = new Size(65, 25);
            lblSalesForDate.TabIndex = 3;
            lblSalesForDate.Text = "₱0.00";
            // 
            // panelMiddle
            // 
            panelMiddle.BackColor = Color.Transparent;
            panelMiddle.ColumnCount = 2;
            panelMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            panelMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelMiddle.Controls.Add(panelChartWrap, 0, 0);
            panelMiddle.Controls.Add(panelTopSellersWrap, 1, 0);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(16, 130);
            panelMiddle.Margin = new Padding(0, 0, 0, 8);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.RowCount = 1;
            panelMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelMiddle.Size = new Size(975, 190);
            panelMiddle.TabIndex = 1;
            // 
            // panelChartWrap
            // 
            panelChartWrap.BackColor = Color.Transparent;
            panelChartWrap.Controls.Add(panelChart);
            panelChartWrap.Controls.Add(lblChartTitle);
            panelChartWrap.Dock = DockStyle.Fill;
            panelChartWrap.Location = new Point(0, 0);
            panelChartWrap.Margin = new Padding(0, 0, 10, 0);
            panelChartWrap.Name = "panelChartWrap";
            panelChartWrap.Size = new Size(575, 190);
            panelChartWrap.TabIndex = 0;
            // 
            // panelChart
            // 
            panelChart.BackColor = Color.FromArgb(31, 30, 68);
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(0, 23);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(575, 167);
            panelChart.TabIndex = 0;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Dock = DockStyle.Top;
            lblChartTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.Gainsboro;
            lblChartTitle.Location = new Point(0, 0);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Padding = new Padding(0, 0, 0, 4);
            lblChartTitle.Size = new Size(139, 23);
            lblChartTitle.TabIndex = 1;
            lblChartTitle.Text = "Sales — Last 7 Days";
            // 
            // panelTopSellersWrap
            // 
            panelTopSellersWrap.BackColor = Color.Transparent;
            panelTopSellersWrap.Controls.Add(dgridTopSellers);
            panelTopSellersWrap.Controls.Add(lblTopSellersTitle);
            panelTopSellersWrap.Dock = DockStyle.Fill;
            panelTopSellersWrap.Location = new Point(585, 0);
            panelTopSellersWrap.Margin = new Padding(0);
            panelTopSellersWrap.Name = "panelTopSellersWrap";
            panelTopSellersWrap.Size = new Size(390, 190);
            panelTopSellersWrap.TabIndex = 1;
            // 
            // dgridTopSellers
            // 
            dgridTopSellers.AllowUserToResizeColumns = false;
            dgridTopSellers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgridTopSellers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgridTopSellers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridTopSellers.BackgroundColor = Color.FromArgb(34, 33, 74);
            dgridTopSellers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dgridTopSellers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgridTopSellers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgridTopSellers.DefaultCellStyle = dataGridViewCellStyle3;
            dgridTopSellers.Dock = DockStyle.Fill;
            dgridTopSellers.GridColor = Color.FromArgb(60, 59, 110);
            dgridTopSellers.Location = new Point(0, 23);
            dgridTopSellers.Name = "dgridTopSellers";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgridTopSellers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgridTopSellers.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DodgerBlue;
            dgridTopSellers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgridTopSellers.Size = new Size(390, 167);
            dgridTopSellers.TabIndex = 70;
            // 
            // lblTopSellersTitle
            // 
            lblTopSellersTitle.AutoSize = true;
            lblTopSellersTitle.Dock = DockStyle.Top;
            lblTopSellersTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTopSellersTitle.ForeColor = Color.Gainsboro;
            lblTopSellersTitle.Location = new Point(0, 0);
            lblTopSellersTitle.Name = "lblTopSellersTitle";
            lblTopSellersTitle.Padding = new Padding(0, 0, 0, 4);
            lblTopSellersTitle.Size = new Size(126, 23);
            lblTopSellersTitle.TabIndex = 71;
            lblTopSellersTitle.Text = "Top 5 Best Sellers";
            // 
            // panelSectionHeader
            // 
            panelSectionHeader.BackColor = Color.Transparent;
            panelSectionHeader.Controls.Add(lblLowStacks);
            panelSectionHeader.Controls.Add(btnRefresh);
            panelSectionHeader.Controls.Add(btnPrintLowStock);
            panelSectionHeader.Controls.Add(panel3);
            panelSectionHeader.Dock = DockStyle.Fill;
            panelSectionHeader.Location = new Point(16, 332);
            panelSectionHeader.Margin = new Padding(0, 4, 0, 4);
            panelSectionHeader.Name = "panelSectionHeader";
            panelSectionHeader.Size = new Size(975, 32);
            panelSectionHeader.TabIndex = 2;
            // 
            // lblLowStacks
            // 
            lblLowStacks.AutoSize = true;
            lblLowStacks.Dock = DockStyle.Top;
            lblLowStacks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLowStacks.ForeColor = Color.Gainsboro;
            lblLowStacks.Location = new Point(0, 0);
            lblLowStacks.Name = "lblLowStacks";
            lblLowStacks.Padding = new Padding(0, 0, 0, 4);
            lblLowStacks.Size = new Size(83, 23);
            lblLowStacks.TabIndex = 72;
            lblLowStacks.Text = "Low Stocks";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(172, 126, 241);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 16;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(1657, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(104, 32);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPrintLowStock
            // 
            btnPrintLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintLowStock.BackColor = Color.FromArgb(128, 128, 255);
            btnPrintLowStock.FlatAppearance.BorderSize = 0;
            btnPrintLowStock.FlatStyle = FlatStyle.Flat;
            btnPrintLowStock.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPrintLowStock.ForeColor = Color.Black;
            btnPrintLowStock.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrintLowStock.IconColor = Color.Black;
            btnPrintLowStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrintLowStock.IconSize = 18;
            btnPrintLowStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrintLowStock.Location = new Point(1547, 2);
            btnPrintLowStock.Name = "btnPrintLowStock";
            btnPrintLowStock.Size = new Size(100, 32);
            btnPrintLowStock.TabIndex = 1;
            btnPrintLowStock.Text = "PRINT";
            btnPrintLowStock.TextAlign = ContentAlignment.MiddleRight;
            btnPrintLowStock.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrintLowStock.UseVisualStyleBackColor = false;
            btnPrintLowStock.Click += btnPrintLowStock_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 0);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(8, 5);
            label4.Name = "label4";
            label4.Size = new Size(124, 16);
            label4.TabIndex = 0;
            label4.Text = "Low Stock Items:";
            // 
            // dgridLowStock
            // 
            dgridLowStock.AllowUserToResizeColumns = false;
            dgridLowStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgridLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgridLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridLowStock.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dgridLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgridLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.Transparent;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgridLowStock.DefaultCellStyle = dataGridViewCellStyle8;
            dgridLowStock.Dock = DockStyle.Fill;
            dgridLowStock.GridColor = SystemColors.Desktop;
            dgridLowStock.Location = new Point(16, 368);
            dgridLowStock.Margin = new Padding(0, 0, 0, 4);
            dgridLowStock.MultiSelect = false;
            dgridLowStock.Name = "dgridLowStock";
            dgridLowStock.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Transparent;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgridLowStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgridLowStock.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dgridLowStock.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgridLowStock.Size = new Size(975, 238);
            dgridLowStock.TabIndex = 63;
            dgridLowStock.CellContentClick += dgridLowStock_CellContentClick;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1007, 622);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            Text = "Dashboard";
            Load += AdminDashboard_Load;
            rootLayout.ResumeLayout(false);
            panelCards.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalInventory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panelLookup.ResumeLayout(false);
            panelLookup.PerformLayout();
            panelMiddle.ResumeLayout(false);
            panelChartWrap.ResumeLayout(false);
            panelChartWrap.PerformLayout();
            panelTopSellersWrap.ResumeLayout(false);
            panelTopSellersWrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgridTopSellers).EndInit();
            panelSectionHeader.ResumeLayout(false);
            panelSectionHeader.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLowStock).EndInit();
            ResumeLayout(false);
        }

        // ── Control declarations ───────────────────────────────────────────────
        private TableLayoutPanel rootLayout;

        private TableLayoutPanel panelCards;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconTotalInventory;
        private Label lblTotalInventory;
        private Label label1;

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblLowStock;
        private Label label2;

        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label lblTotalSalesToday;
        private Label label3;

        private Panel panelLookup;
        private Label lblLookupTitle;
        private DateTimePicker dtpSalesLookup;
        private FontAwesome.Sharp.IconButton btnLookupSales;
        private Label lblSalesForDate;

        private TableLayoutPanel panelMiddle;
        private Panel panelChartWrap;
        private Label lblChartTitle;
        private Panel panelChart;
        private Panel panelTopSellersWrap;
        private Label lblTopSellersTitle;
        private DataGridView dgridTopSellers;

        private Panel panelSectionHeader;
        private Panel panel3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnPrintLowStock;
        private FontAwesome.Sharp.IconButton btnRefresh;

        private DataGridView dgridLowStock;
        private Label lblLowStacks;
    }
}
