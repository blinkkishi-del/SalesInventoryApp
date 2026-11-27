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
            rootLayout = new TableLayoutPanel();
            panelCards = new TableLayoutPanel();
            panel1 = new Panel();
            badgeInventory = new Panel();
            iconTotalInventory = new FontAwesome.Sharp.IconPictureBox();
            lblInventorySub = new Label();
            lblTotalInventory = new Label();
            label1 = new Label();
            accentInventory = new Panel();
            panel2 = new Panel();
            badgeLowStock = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblLowStockSub = new Label();
            lblLowStock = new Label();
            label2 = new Label();
            accentLowStock = new Panel();
            panel4 = new Panel();
            badgeSales = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblSalesSub = new Label();
            lblTotalSalesToday = new Label();
            label3 = new Label();
            accentSales = new Panel();
            panelMiddle = new TableLayoutPanel();
            panelChartWrap = new Panel();
            panelChart = new Panel();
            lblChartTitle = new Label();
            panelBottom = new TableLayoutPanel();
            panelLowStock = new Panel();
            dgridLowStock = new DataGridView();
            panelSectionHeader = new Panel();
            lblLowStacks = new Label();
            btnReorder = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            label4 = new Label();
            tableActivity = new TableLayoutPanel();
            lblRecentSales = new Label();
            dgRecentSales = new DataGridView();
            lblRecentStock = new Label();
            dgRecentStock = new DataGridView();
            rootLayout.SuspendLayout();
            panelCards.SuspendLayout();
            panel1.SuspendLayout();
            badgeInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalInventory).BeginInit();
            panel2.SuspendLayout();
            badgeLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel4.SuspendLayout();
            badgeSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panelMiddle.SuspendLayout();
            panelChartWrap.SuspendLayout();
            panelBottom.SuspendLayout();
            panelLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLowStock).BeginInit();
            panelSectionHeader.SuspendLayout();
            panel3.SuspendLayout();
            tableActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRecentSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgRecentStock).BeginInit();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.BackColor = Color.FromArgb(34, 33, 74);
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootLayout.Controls.Add(panelCards, 0, 0);
            rootLayout.Controls.Add(panelMiddle, 0, 1);
            rootLayout.Controls.Add(panelBottom, 0, 2);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Margin = new Padding(0);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16, 12, 16, 12);
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 122F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            rootLayout.Size = new Size(1007, 622);
            rootLayout.TabIndex = 0;
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.Transparent;
            panelCards.ColumnCount = 3;
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            panelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            panelCards.Controls.Add(panel1, 0, 0);
            panelCards.Controls.Add(panel2, 1, 0);
            panelCards.Controls.Add(panel4, 2, 0);
            panelCards.Dock = DockStyle.Fill;
            panelCards.Location = new Point(16, 12);
            panelCards.Margin = new Padding(0, 0, 0, 10);
            panelCards.Name = "panelCards";
            panelCards.RowCount = 1;
            panelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCards.Size = new Size(975, 112);
            panelCards.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 43, 92);
            panel1.Controls.Add(badgeInventory);
            panel1.Controls.Add(lblInventorySub);
            panel1.Controls.Add(lblTotalInventory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(accentInventory);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 112);
            panel1.TabIndex = 0;
            // 
            // badgeInventory
            // 
            badgeInventory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            badgeInventory.BackColor = Color.FromArgb(24, 161, 251);
            badgeInventory.Controls.Add(iconTotalInventory);
            badgeInventory.Location = new Point(238, 24);
            badgeInventory.Name = "badgeInventory";
            badgeInventory.Size = new Size(56, 56);
            badgeInventory.TabIndex = 0;
            // 
            // iconTotalInventory
            // 
            iconTotalInventory.BackColor = Color.Transparent;
            iconTotalInventory.Dock = DockStyle.Fill;
            iconTotalInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            iconTotalInventory.IconColor = Color.White;
            iconTotalInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTotalInventory.IconSize = 56;
            iconTotalInventory.Location = new Point(0, 0);
            iconTotalInventory.Name = "iconTotalInventory";
            iconTotalInventory.Size = new Size(56, 56);
            iconTotalInventory.SizeMode = PictureBoxSizeMode.CenterImage;
            iconTotalInventory.TabIndex = 0;
            iconTotalInventory.TabStop = false;
            // 
            // lblInventorySub
            // 
            lblInventorySub.AutoSize = true;
            lblInventorySub.Font = new Font("Segoe UI", 9F);
            lblInventorySub.ForeColor = Color.FromArgb(150, 150, 180);
            lblInventorySub.Location = new Point(20, 80);
            lblInventorySub.Name = "lblInventorySub";
            lblInventorySub.Size = new Size(77, 15);
            lblInventorySub.TabIndex = 1;
            lblInventorySub.Text = "units in stock";
            // 
            // lblTotalInventory
            // 
            lblTotalInventory.AutoSize = true;
            lblTotalInventory.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblTotalInventory.ForeColor = Color.White;
            lblTotalInventory.Location = new Point(16, 34);
            lblTotalInventory.Name = "lblTotalInventory";
            lblTotalInventory.Size = new Size(35, 41);
            lblTotalInventory.TabIndex = 2;
            lblTotalInventory.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(170, 170, 200);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 3;
            label1.Text = "TOTAL INVENTORY";
            // 
            // accentInventory
            // 
            accentInventory.BackColor = Color.FromArgb(24, 161, 251);
            accentInventory.Dock = DockStyle.Left;
            accentInventory.Location = new Point(0, 0);
            accentInventory.Name = "accentInventory";
            accentInventory.Size = new Size(6, 112);
            accentInventory.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 43, 92);
            panel2.Controls.Add(badgeLowStock);
            panel2.Controls.Add(lblLowStockSub);
            panel2.Controls.Add(lblLowStock);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(accentLowStock);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(324, 0);
            panel2.Margin = new Padding(0, 0, 12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 112);
            panel2.TabIndex = 1;
            // 
            // badgeLowStock
            // 
            badgeLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            badgeLowStock.BackColor = Color.FromArgb(239, 68, 68);
            badgeLowStock.Controls.Add(iconPictureBox1);
            badgeLowStock.Location = new Point(238, 24);
            badgeLowStock.Name = "badgeLowStock";
            badgeLowStock.Size = new Size(56, 56);
            badgeLowStock.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Warning;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 56;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(56, 56);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // lblLowStockSub
            // 
            lblLowStockSub.AutoSize = true;
            lblLowStockSub.Font = new Font("Segoe UI", 9F);
            lblLowStockSub.ForeColor = Color.FromArgb(150, 150, 180);
            lblLowStockSub.Location = new Point(20, 80);
            lblLowStockSub.Name = "lblLowStockSub";
            lblLowStockSub.Size = new Size(160, 15);
            lblLowStockSub.TabIndex = 1;
            lblLowStockSub.Text = "products at 10 units or below";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.White;
            lblLowStock.Location = new Point(16, 34);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(35, 41);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(170, 170, 200);
            label2.Location = new Point(20, 14);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 3;
            label2.Text = "LOW STOCKS";
            // 
            // accentLowStock
            // 
            accentLowStock.BackColor = Color.FromArgb(239, 68, 68);
            accentLowStock.Dock = DockStyle.Left;
            accentLowStock.Location = new Point(0, 0);
            accentLowStock.Name = "accentLowStock";
            accentLowStock.Size = new Size(6, 112);
            accentLowStock.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 43, 92);
            panel4.Controls.Add(badgeSales);
            panel4.Controls.Add(lblSalesSub);
            panel4.Controls.Add(lblTotalSalesToday);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(accentSales);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(648, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(327, 112);
            panel4.TabIndex = 2;
            // 
            // badgeSales
            // 
            badgeSales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            badgeSales.BackColor = Color.FromArgb(34, 197, 94);
            badgeSales.Controls.Add(iconPictureBox3);
            badgeSales.Location = new Point(253, 24);
            badgeSales.Name = "badgeSales";
            badgeSales.Size = new Size(56, 56);
            badgeSales.TabIndex = 0;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.Dock = DockStyle.Fill;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PesoSign;
            iconPictureBox3.IconColor = Color.White;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 56;
            iconPictureBox3.Location = new Point(0, 0);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(56, 56);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // lblSalesSub
            // 
            lblSalesSub.AutoSize = true;
            lblSalesSub.Font = new Font("Segoe UI", 9F);
            lblSalesSub.ForeColor = Color.FromArgb(150, 150, 180);
            lblSalesSub.Location = new Point(20, 80);
            lblSalesSub.Name = "lblSalesSub";
            lblSalesSub.Size = new Size(74, 15);
            lblSalesSub.TabIndex = 1;
            lblSalesSub.Text = "0 sales today";
            // 
            // lblTotalSalesToday
            // 
            lblTotalSalesToday.AutoSize = true;
            lblTotalSalesToday.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblTotalSalesToday.ForeColor = Color.White;
            lblTotalSalesToday.Location = new Point(16, 34);
            lblTotalSalesToday.Name = "lblTotalSalesToday";
            lblTotalSalesToday.Size = new Size(94, 41);
            lblTotalSalesToday.TabIndex = 2;
            lblTotalSalesToday.Text = "₱0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(170, 170, 200);
            label3.Location = new Point(20, 14);
            label3.Name = "label3";
            label3.Size = new Size(108, 19);
            label3.TabIndex = 3;
            label3.Text = "TODAY'S SALES";
            // 
            // accentSales
            // 
            accentSales.BackColor = Color.FromArgb(34, 197, 94);
            accentSales.Dock = DockStyle.Left;
            accentSales.Location = new Point(0, 0);
            accentSales.Name = "accentSales";
            accentSales.Size = new Size(6, 112);
            accentSales.TabIndex = 4;
            // 
            // panelMiddle
            // 
            panelMiddle.BackColor = Color.Transparent;
            panelMiddle.ColumnCount = 1;
            panelMiddle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelMiddle.Controls.Add(panelChartWrap, 0, 0);
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(16, 134);
            panelMiddle.Margin = new Padding(0, 0, 0, 8);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.RowCount = 1;
            panelMiddle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelMiddle.Size = new Size(975, 206);
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
            panelChartWrap.Size = new Size(965, 206);
            panelChartWrap.TabIndex = 0;
            // 
            // panelChart
            // 
            panelChart.BackColor = Color.FromArgb(31, 30, 68);
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(0, 23);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(965, 183);
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
            // panelBottom
            // 
            panelBottom.BackColor = Color.Transparent;
            panelBottom.ColumnCount = 2;
            panelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            panelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            panelBottom.Controls.Add(panelLowStock, 0, 0);
            panelBottom.Controls.Add(tableActivity, 1, 0);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(16, 348);
            panelBottom.Margin = new Padding(0);
            panelBottom.Name = "panelBottom";
            panelBottom.RowCount = 1;
            panelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelBottom.Size = new Size(975, 262);
            panelBottom.TabIndex = 2;
            // 
            // panelLowStock
            // 
            panelLowStock.Controls.Add(dgridLowStock);
            panelLowStock.Controls.Add(panelSectionHeader);
            panelLowStock.Dock = DockStyle.Fill;
            panelLowStock.Location = new Point(0, 0);
            panelLowStock.Margin = new Padding(0, 0, 10, 0);
            panelLowStock.Name = "panelLowStock";
            panelLowStock.Size = new Size(555, 262);
            panelLowStock.TabIndex = 0;
            // 
            // dgridLowStock
            // 
            dgridLowStock.AllowUserToResizeColumns = false;
            dgridLowStock.AllowUserToResizeRows = false;
            dgridLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridLowStock.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgridLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgridLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgridLowStock.DefaultCellStyle = dataGridViewCellStyle2;
            dgridLowStock.Dock = DockStyle.Fill;
            dgridLowStock.GridColor = SystemColors.Desktop;
            dgridLowStock.Location = new Point(0, 40);
            dgridLowStock.Margin = new Padding(0);
            dgridLowStock.MultiSelect = false;
            dgridLowStock.Name = "dgridLowStock";
            dgridLowStock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgridLowStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgridLowStock.RowHeadersWidth = 51;
            dgridLowStock.Size = new Size(555, 222);
            dgridLowStock.TabIndex = 63;
            dgridLowStock.CellDoubleClick += dgridLowStock_CellDoubleClick;
            // 
            // panelSectionHeader
            // 
            panelSectionHeader.BackColor = Color.Transparent;
            panelSectionHeader.Controls.Add(lblLowStacks);
            panelSectionHeader.Controls.Add(btnReorder);
            panelSectionHeader.Controls.Add(panel3);
            panelSectionHeader.Dock = DockStyle.Top;
            panelSectionHeader.Location = new Point(0, 0);
            panelSectionHeader.Margin = new Padding(0, 4, 0, 4);
            panelSectionHeader.Name = "panelSectionHeader";
            panelSectionHeader.Size = new Size(555, 40);
            panelSectionHeader.TabIndex = 2;
            // 
            // lblLowStacks
            // 
            lblLowStacks.Dock = DockStyle.Left;
            lblLowStacks.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLowStacks.ForeColor = Color.Gainsboro;
            lblLowStacks.Location = new Point(0, 0);
            lblLowStacks.Name = "lblLowStacks";
            lblLowStacks.Size = new Size(120, 40);
            lblLowStacks.TabIndex = 72;
            lblLowStacks.Text = "Low Stocks";
            lblLowStacks.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReorder
            // 
            btnReorder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReorder.BackColor = Color.MediumSeaGreen;
            btnReorder.Cursor = Cursors.Hand;
            btnReorder.FlatAppearance.BorderSize = 0;
            btnReorder.FlatStyle = FlatStyle.Flat;
            btnReorder.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnReorder.ForeColor = Color.White;
            btnReorder.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            btnReorder.IconColor = Color.White;
            btnReorder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReorder.IconSize = 18;
            btnReorder.Location = new Point(443, 4);
            btnReorder.Name = "btnReorder";
            btnReorder.Size = new Size(112, 32);
            btnReorder.TabIndex = 3;
            btnReorder.Text = "REORDER";
            btnReorder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReorder.UseVisualStyleBackColor = false;
            btnReorder.Click += btnReorder_Click;
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
            // tableActivity
            // 
            tableActivity.BackColor = Color.Transparent;
            tableActivity.ColumnCount = 1;
            tableActivity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableActivity.Controls.Add(lblRecentSales, 0, 0);
            tableActivity.Controls.Add(dgRecentSales, 0, 1);
            tableActivity.Controls.Add(lblRecentStock, 0, 2);
            tableActivity.Controls.Add(dgRecentStock, 0, 3);
            tableActivity.Dock = DockStyle.Fill;
            tableActivity.Location = new Point(565, 0);
            tableActivity.Margin = new Padding(0);
            tableActivity.Name = "tableActivity";
            tableActivity.RowCount = 4;
            tableActivity.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableActivity.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableActivity.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableActivity.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableActivity.Size = new Size(410, 262);
            tableActivity.TabIndex = 1;
            // 
            // lblRecentSales
            // 
            lblRecentSales.Dock = DockStyle.Fill;
            lblRecentSales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecentSales.ForeColor = Color.Gainsboro;
            lblRecentSales.Location = new Point(3, 0);
            lblRecentSales.Name = "lblRecentSales";
            lblRecentSales.Size = new Size(404, 40);
            lblRecentSales.TabIndex = 0;
            lblRecentSales.Text = "Recent Sales";
            lblRecentSales.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgRecentSales
            // 
            dgRecentSales.Dock = DockStyle.Fill;
            dgRecentSales.Location = new Point(0, 44);
            dgRecentSales.Margin = new Padding(0, 4, 0, 4);
            dgRecentSales.Name = "dgRecentSales";
            dgRecentSales.Size = new Size(410, 88);
            dgRecentSales.TabIndex = 1;
            // 
            // lblRecentStock
            // 
            lblRecentStock.Dock = DockStyle.Fill;
            lblRecentStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecentStock.ForeColor = Color.Gainsboro;
            lblRecentStock.Location = new Point(3, 136);
            lblRecentStock.Name = "lblRecentStock";
            lblRecentStock.Size = new Size(404, 30);
            lblRecentStock.TabIndex = 2;
            lblRecentStock.Text = "Recent Stock Movements";
            lblRecentStock.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgRecentStock
            // 
            dgRecentStock.Dock = DockStyle.Fill;
            dgRecentStock.Location = new Point(0, 170);
            dgRecentStock.Margin = new Padding(0, 4, 0, 0);
            dgRecentStock.Name = "dgRecentStock";
            dgRecentStock.Size = new Size(410, 92);
            dgRecentStock.TabIndex = 3;
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
            badgeInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconTotalInventory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            badgeLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            badgeSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panelMiddle.ResumeLayout(false);
            panelChartWrap.ResumeLayout(false);
            panelChartWrap.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridLowStock).EndInit();
            panelSectionHeader.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgRecentSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgRecentStock).EndInit();
            ResumeLayout(false);
        }

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

        private TableLayoutPanel panelMiddle;
        private Panel panelChartWrap;
        private Label lblChartTitle;
        private Panel panelChart;

        private Panel panelSectionHeader;
        private Panel panel3;
        private Label label4;

        private DataGridView dgridLowStock;
        private TableLayoutPanel panelBottom;
        private Panel accentInventory;
        private Panel accentLowStock;
        private Panel accentSales;
        private Panel badgeInventory;
        private Panel badgeLowStock;
        private Panel badgeSales;
        private Label lblInventorySub;
        private Label lblLowStockSub;
        private Label lblSalesSub;
        private Panel panelLowStock;
        private FontAwesome.Sharp.IconButton btnReorder;
        private TableLayoutPanel tableActivity;
        private Label lblRecentSales;
        private DataGridView dgRecentSales;
        private Label lblRecentStock;
        private DataGridView dgRecentStock;
        private Label lblLowStacks;
    }
}
