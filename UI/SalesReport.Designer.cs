namespace UI
{
    partial class SalesReport
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnPrint = new FontAwesome.Sharp.IconButton();
            cbDateMonth = new ComboBox();
            dgList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PaleGreen;
            btnSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 23;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(353, 32);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 51);
            btnSearch.TabIndex = 57;
            btnSearch.Text = "SEARCH";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.Font = new Font("Arial", 14.25F);
            txtSearch.Location = new Point(42, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Items Here";
            txtSearch.Size = new Size(305, 35);
            txtSearch.TabIndex = 56;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Silver;
            btnRefresh.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.Black;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 23;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(829, 32);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(122, 51);
            btnRefresh.TabIndex = 60;
            btnRefresh.Text = "REFRESH";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(128, 128, 255);
            btnPrint.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Black;
            btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnPrint.IconColor = Color.Black;
            btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrint.IconSize = 23;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(984, 32);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(122, 51);
            btnPrint.TabIndex = 61;
            btnPrint.Text = "PRINT";
            btnPrint.TextAlign = ContentAlignment.MiddleRight;
            btnPrint.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // cbDateMonth
            // 
            cbDateMonth.Font = new Font("Arial", 14.25F);
            cbDateMonth.FormattingEnabled = true;
            cbDateMonth.Location = new Point(518, 39);
            cbDateMonth.Name = "cbDateMonth";
            cbDateMonth.Size = new Size(281, 35);
            cbDateMonth.TabIndex = 62;
            // 
            // dgList
            // 
            dgList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgList.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgList.DefaultCellStyle = dataGridViewCellStyle4;
            dgList.Location = new Point(14, 160);
            dgList.Name = "dgList";
            dgList.RowHeadersWidth = 51;
            dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgList.Size = new Size(1125, 566);
            dgList.TabIndex = 63;
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1151, 738);
            Controls.Add(dgList);
            Controls.Add(cbDateMonth);
            Controls.Add(btnPrint);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            ForeColor = Color.Black;
            Name = "SalesReport";
            Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnPrint;
        private ComboBox cbDateMonth;
        private DataGridView dgList;
    }
}