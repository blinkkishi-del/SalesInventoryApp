namespace UI
{
    partial class PointofSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            datetpDate = new DateTimePicker();
            label2 = new Label();
            lblPay = new Label();
            lblTotal = new Label();
            lblReceiptNo = new Label();
            lblDate = new Label();
            lblStorename = new Label();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            dgProducts = new DataGridView();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(datetpDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblPay);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblReceiptNo);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblStorename);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(dgProducts);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 738);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // datetpDate
            // 
            datetpDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            datetpDate.CalendarFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            datetpDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datetpDate.Location = new Point(766, 182);
            datetpDate.Name = "datetpDate";
            datetpDate.Size = new Size(330, 34);
            datetpDate.TabIndex = 73;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(667, 697);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 72;
            label2.Text = "Change:";
            // 
            // lblPay
            // 
            lblPay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPay.AutoSize = true;
            lblPay.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblPay.ForeColor = Color.Black;
            lblPay.Location = new Point(667, 654);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(73, 31);
            lblPay.TabIndex = 71;
            lblPay.Text = "Pay:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(667, 602);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 31);
            lblTotal.TabIndex = 70;
            lblTotal.Text = "Total: ";
            // 
            // lblReceiptNo
            // 
            lblReceiptNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblReceiptNo.AutoSize = true;
            lblReceiptNo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblReceiptNo.ForeColor = Color.Black;
            lblReceiptNo.Location = new Point(667, 237);
            lblReceiptNo.Name = "lblReceiptNo";
            lblReceiptNo.Size = new Size(168, 31);
            lblReceiptNo.TabIndex = 69;
            lblReceiptNo.Text = "Receipt No:";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(667, 182);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(93, 31);
            lblDate.TabIndex = 68;
            lblDate.Text = "Date: ";
            // 
            // lblStorename
            // 
            lblStorename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStorename.AutoSize = true;
            lblStorename.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblStorename.ForeColor = Color.Black;
            lblStorename.Location = new Point(667, 132);
            lblStorename.Name = "lblStorename";
            lblStorename.Size = new Size(177, 31);
            lblStorename.TabIndex = 67;
            lblStorename.Text = "Store Name:";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.Silver;
            btnCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 23;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(232, 674);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 51);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "CANCEL";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 23;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(60, 674);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 51);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "DELETE";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgProducts
            // 
            dgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgProducts.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgProducts.Location = new Point(12, 115);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(626, 538);
            dgProducts.TabIndex = 57;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Silver;
            btnSearch.Font = new Font("Arial", 11.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Black;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 26;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(436, 53);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(164, 53);
            btnSearch.TabIndex = 56;
            btnSearch.Text = "SEARCH";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.Font = new Font("Segoe UI", 14F);
            txtSearch.Location = new Point(100, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Items Here";
            txtSearch.Size = new Size(314, 39);
            txtSearch.TabIndex = 51;
            // 
            // PointofSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 738);
            Controls.Add(panel1);
            Name = "PointofSales";
            Text = "PointofSales";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private DataGridView dgProducts;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnCancel;
        private DateTimePicker datetpDate;
        private Label label2;
        private Label lblPay;
        private Label lblTotal;
        private Label lblReceiptNo;
        private Label lblDate;
        private Label lblStorename;
    }
}